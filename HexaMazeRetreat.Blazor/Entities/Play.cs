using System;

namespace HexaMazeRetreat.Blazor.Entities
{
    public class Play
    {
        public Guid Id { get; set; }
        public int SysId { get; set; }
        public string PlayerName { get; set; }
        public string LevelName { get; set; }
        public string Description { get; set; }
        public DateTime SubmittedOn { get; set; }
        public string SubmittedSolution { get; set; }
    }
}