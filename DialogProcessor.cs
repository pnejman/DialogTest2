using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DialogTest2
{
    public class DialogProcessor
    {
        private List<DialogLine> processedSceneLines = new List<DialogLine>();

        private void FancyWriter(string textToDisplay, int currentLine) //display texts letter by letter
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            DisplayRawAvatar(processedSceneLines, currentLine);
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int currentChar = 0; currentChar < textToDisplay.Length; currentChar++)
            {
                Console.Write(textToDisplay[currentChar]);
                Thread.Sleep(50);
            }
            Console.ReadKey(true);
        }

        private void DisplayRawAvatar(List<DialogLine> processedSceneLines, int currentLine) //just display "picture" and name
        {
            Console.WriteLine("╔════╗");
            Console.WriteLine("║");
            Console.WriteLine($"║ faces.{processedSceneLines[currentLine].speakerName}.{processedSceneLines[currentLine].speakerMood}.png");
            Console.WriteLine("║");
            Console.WriteLine("╚════╝");
            Console.WriteLine($"{ processedSceneLines[currentLine].speakerName}:\r\n");
        }

        private void AvatarFadeIn(List<DialogLine> processedSceneLines, int currentLine) //avatar fades in
        {
            Console.Clear();
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);
        }

        private void AvatarFadeOut(List<DialogLine> processedSceneLines, int currentLine) //avatar fades out
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            DisplayRawAvatar(processedSceneLines, currentLine);
            Thread.Sleep(100);

            Console.Clear();
            Thread.Sleep(100);
        }

        public DialogProcessor(List<DialogLine> processedSceneLines) //constructor with single argument
        {
            this.processedSceneLines = processedSceneLines; //store these as class variable

            for (int currentLine = 0; currentLine < processedSceneLines.Count; currentLine++) //all those gizmos are to check if there are two lines of the same speaker one by one. If so - no fade in/fade out animations should be played
            {
                if (currentLine == 0)
                {
                    AvatarFadeIn(processedSceneLines, currentLine);
                }
                else if (processedSceneLines.Count > 1)
                {
                    if (processedSceneLines[currentLine - 1].speakerName != processedSceneLines[currentLine].speakerName)
                    {
                        AvatarFadeIn(processedSceneLines, currentLine);
                    }
                }

                this.FancyWriter($"\t\"{ processedSceneLines[currentLine].spokenLine}\"\r\n", currentLine); //call smooth writing

                if (currentLine < processedSceneLines.Count-1)
                {
                    if (processedSceneLines[currentLine].speakerName != processedSceneLines[currentLine+1].speakerName)
                    {
                        AvatarFadeOut(processedSceneLines, currentLine);
                    }
                }
                else if (currentLine == processedSceneLines.Count - 1)
                {
                    AvatarFadeOut(processedSceneLines, currentLine);
                }
            }
        }
    }
}
