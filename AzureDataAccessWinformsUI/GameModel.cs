namespace AzureDataAccessWinformsUI
{
    public class GameModel
    {
        public int Id { get; set; }
        public string NameOfGame { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Id} - {NameOfGame} - {Description}";
        }
    }
}