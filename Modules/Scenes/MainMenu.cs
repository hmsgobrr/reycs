using Raylib_cs;

namespace ReyCS.Modules.Scenes
{
    public class MainMenu : Scene
    {
        public void init()
        {

        }
        public void update()
        {

        }
        public void draw()
        {
            Raylib.ClearBackground(Color.RAYWHITE);
            Raylib.DrawText("Press [ENTER] to play", Program.SWIDTH/2-Raylib.MeasureText("Press [ENTER] to play", 25)/2, 300, 25, Color.DARKGRAY);
        }
    }
}