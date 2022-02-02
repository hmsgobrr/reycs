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
            Raylib.DrawText("Tis e mein menyu", 0, 0, 10, Color.DARKGRAY);
        }
    }
}