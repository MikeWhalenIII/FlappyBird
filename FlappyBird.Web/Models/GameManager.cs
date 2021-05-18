namespace FlappyBird.Web.Models
{
    public class GameManager
    {
        private readonly int _gravity = 2;
        
        public BirdModel Bird { get; set; }
        public bool IsRunning { get; set; } = false;

        public GameManager()
        {
            Bird = new BirdModel();
        }

        public async void MainLoop()
        {
            IsRunning = true;
            while(IsRunning)
            {
                Bird.Fall(2);
            }
        }
    }
}
