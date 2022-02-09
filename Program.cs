using Raylib_cs;
using ReyCS.Modules;
using ReyCS.Modules.Scenes;

namespace ReyCS
{
    static class Program
    {
        public static int SWIDTH = 500;
        public static int SHEIGHT = 650;
 
        private static Scene scene = new MainMenu();

        private static Dictionary<Type, Scene> sceneCache = new Dictionary<Type, Scene>();

        public static void setScene<T>() where T : Scene, new()
        {
            Scene newScene = sceneCache[typeof(T)];
            if (scene == null)
            {
                newScene = new T();
                sceneCache.Add(typeof(T), newScene);
            }
            scene = newScene;
        }

        public static void Main()
        {
            sceneCache.Add(scene.GetType(), scene);

            Raylib.InitWindow(SWIDTH, SHEIGHT, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                scene.draw();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
