using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;

namespace EnumCompareToBenchmark {
    [DisassemblyDiagnoser(printSource: true)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public class EnumCompareToBenchmark {
        List<DownloadItem> data;

        [GlobalSetup]
        public void Setup() {
            int count = 1000;
            data = new List<DownloadItem>(count);
            for(int i = 0; i < count; i++) {
                DownloadStatus status = DownloadStatus.Cancelled;
                if(i % 3 == 0) status = DownloadStatus.Completed;
                if(i % 5 == 0) status = DownloadStatus.InProgress;
                data.Add(new DownloadItem { Status = status });
            }
        }

        static int CompareValueType(DownloadItem x, DownloadItem y) {
            return ((int)x.Status).CompareTo(((int)y.Status));
        }
        static int CompareBoxing(DownloadItem x, DownloadItem y) {
            return (x.Status.CompareTo(y.Status));
        }

        [Benchmark]
        public List<DownloadItem> Simple() {
            data.Sort(CompareValueType);
            return data;
        }

        [Benchmark]
        public List<DownloadItem> Box() {
            data.Sort(CompareBoxing);
            return data;
        }
    }

    public enum DownloadStatus {
        InProgress,
        Waiting,
        Completed,
        Cancelled
    }

    public class DownloadItem {
        public DownloadStatus Status { get; set; }
    }
}
