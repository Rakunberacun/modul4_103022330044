namespace modul4_103022330044
{
    public class FanLaptop
    {


        public enum FanState
        {
            Quiet, Turbo, Balanced, Performance
        }

        private FanState currentState;
        public FanLaptop()
        {
            currentState = FanState.Quiet;
        }
        public void modeDown()
        {
            if (currentState == FanState.Quiet)
            {
                currentState = FanState.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");

            }
            else if (currentState == FanState.Turbo)
            {
                currentState = FanState.Performance;
            }
            else if (currentState == FanState.Balanced)
            {
                currentState = FanState.Quiet;
            }
            else if (currentState == FanState.Performance)
            {
                currentState = FanState.Balanced;
            }
        }
        public void modeUp()
        {
            if (currentState == FanState.Quiet)
            {
                currentState = FanState.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
            else if (currentState == FanState.Balanced)
            {
                currentState = FanState.Performance;
            }
            else if (currentState == FanState.Performance)
            {
                currentState = FanState.Turbo;
            }
        }
        public void turboShortcut()
        {
            if (currentState == FanState.Quiet)
            {
                currentState = FanState.Turbo;
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
            }
            else if (currentState == FanState.Turbo)
            {
                currentState = FanState.Quiet;
            }
        }
        public void ShowState()
        {
            Console.WriteLine($"Status fan saat ini: {currentState}");
        }
    }
}