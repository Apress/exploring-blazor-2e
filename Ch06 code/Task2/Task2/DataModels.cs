namespace Task2
{
    public class DataModels
    {
        public class PointScoredModel
        {
            public Guid id { get; set; }
            public int value { get; set; }
        }
        public class ReboundModel
        {
            public Guid id { get; set; }
        }
        public class FoulModel
        {
            public Guid id { get; set; }
        }

        public class BlockModel
        {
            public Guid id { get; set; }
        }

    }
}
