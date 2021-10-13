namespace HexaMazeRetreat.Domain.Contracts
{
    public class GetLevelByNameResponse
    {
        public string LevelName { get; set; }
        public MazeMap Map { get; set; }
    }
}