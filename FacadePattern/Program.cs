namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvdPlayer, cdPlayer, projector, lights, screen, popcornPopper);

            homeTheater.WatchMovie("Manuel vs ai jack sparrow *gasp*");
            homeTheater.EndMovie();
            // voor robert :: ik heb alle methodes gecheckt volgens stap 5 met console.writeline,
            //                alleen eruit gehaald voor overzicht
        }
    }
}