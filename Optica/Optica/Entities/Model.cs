﻿namespace Optica.Entities
{
    public enum Sort { INCREASE, REDUCE, MULTIFOCAL }
    public enum Target { OLDER, BABY, CHILDREN }
    public class Model
    {
        public int Code { get; set; }
        public string Id { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public double Scop { get; set; }
        public string Shape { get; set; }
        public Sort GlassSort { get; set; }
        public Target GlassTarget { get; set; }
    }
}
