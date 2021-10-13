namespace HexaMazeRetreat.Domain.Contracts
{
    public class CreatePlayRequest
    {
        public string PlayerName { get; set; }
        public Solution SubmittedSolution { get; set; }
    }
}