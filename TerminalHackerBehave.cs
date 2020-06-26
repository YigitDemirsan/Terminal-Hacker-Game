using System;
using UnityEngine;

public class TerminalHackerBehave : MonoBehaviour

    {
    private int score = 0;
    private String[] levelOnePasswords = { "123code123", "f***u", "12345", "password", "AbCdWgamer123", "Super7" };
    private String[] levelTwoPasswords = { "123WeNeVeRFORGIVe456", "<|2*3=6/2=3+1=4|>", "PIX0stv0jobs0APP", "-OzUHey-" };
    private String[] levelTheerePasswords = { "78190", "14903", "01010", "4781","9478","1234" };
    private String[] levelFourPasswords = { "09-11//UA275", "TpSc//INFOSSS547", "tR@_TE874123", "S*F*9#0V10TRBT" };
    private int level;
    enum Screen { MainMenu , HackProgress , HackingPart , PasswordGuess , Win };
    Screen currentScreen = Screen.MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        DateTime date = DateTime.Now;
        showMainMenu(date);
    }

    private void showMainMenu(DateTime date) {
        Terminal.WriteLine("" + date+"  Score:"+this.score);
        Terminal.WriteLine("");
        Terminal.WriteLine("<Welcome to hacking simulator>\n");
        Terminal.WriteLine("Please choose an option");
        Terminal.WriteLine("\t-->$ Social Media Account / Press 1");
        Terminal.WriteLine("\t-->$ Web Site            / Press 2");
        Terminal.WriteLine("\t-->$ Bank Account       / Press 3");
        Terminal.WriteLine("\t-->$ Goverment Files   / Press 4\n");
        Terminal.WriteLine("Enter your choice:");
    }
    private void OnUserInput(String input) {
        if (input.Equals("Menu"))
        {
            Terminal.ClearScreen();
            this.level = 0;
            this.currentScreen = Screen.MainMenu;
            DateTime date = DateTime.Now;
            showMainMenu(date);

        }
        else if (this.currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (this.currentScreen == Screen.HackProgress && this.level == 1)
        {
            HackerMenu(input);
        }
        else if (this.currentScreen == Screen.HackingPart && this.level == 1)
        {
            RunHackPart(input);
        }
        else if (this.currentScreen == Screen.PasswordGuess && this.level == 1)
        {
            PasswordGuess(input);
        }
        else if (this.currentScreen == Screen.HackProgress && this.level == 2)
        {
            HackerMenu(input);
        }
        else if (this.currentScreen == Screen.HackingPart && this.level == 2)
        {
            RunHackPart(input);
        }
        else if (this.currentScreen == Screen.PasswordGuess && this.level == 2)
        {
            PasswordGuess(input);
        }
        else if (this.currentScreen == Screen.HackProgress && this.level == 3)
        {
            HackerMenu(input);
        }
        else if (this.currentScreen == Screen.HackingPart && this.level == 3)
        {
            RunHackPart(input);
        }
        else if (this.currentScreen == Screen.PasswordGuess && this.level == 3)
        {
            PasswordGuess(input);
        }
        else if (this.currentScreen == Screen.HackProgress && this.level == 4)
        {
            HackerMenu(input);
        }
        else if (this.currentScreen == Screen.HackingPart && this.level == 4)
        {
            RunHackPart(input);
        }
        else if (this.currentScreen == Screen.PasswordGuess && this.level == 4)
        {
            PasswordGuess(input);
        }
    }
    private void RunMainMenu(String input) {
        if (input.Equals("1"))
        {
            this.level = 1;
            startGame();
        }
        else if (input.Equals("2") )
        {
            this.level = 2;
            startGame();
        }
        else if (input.Equals("3") && this.score > 3000)
        {
            this.level = 3;
            startGame();
        }
        else if (input.Equals("4") && this.score > 15000) {
            this.level = 4;
            startGame();
        }
        else
        {
            Terminal.WriteLine("You enter wrong number or your score not enough for next level");
        }
    }
    private void HackerMenu(String input) {
        if (this.level == 1)
        {
            if (input.Equals("Gameuser123"))
            {
                Terminal.WriteLine("You decide to hack " + input);
                Terminal.WriteLine("Please start to hacking progress\nIf your first time write a($-->cd/SCM/HackFile/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("GreatSpacePc"))
            {
                Terminal.WriteLine("You decide to hack " + input);
                Terminal.WriteLine("Please start to hacking progress\nIf your first time write a($-->cd/SCM/HackFile/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("DirtyGirlXxX"))
            {
                Terminal.WriteLine("You decide to hack " + input);
                Terminal.WriteLine("Please start to hacking progress\nIf your first time write a($-->cd/SCM/HackFile/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("asd@123@|_"))
            {
                Terminal.WriteLine("You decide to hack " + input);
                Terminal.WriteLine("Please start to hacking progress\nIf your first time write a($-->cd/SCM/HackFile/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else
            {
                Terminal.WriteLine("You enter wrong victim name.....\n/PLEASE RETURN MENU/");
            }
        }
        else if (this.level == 2)
        {
            if (input.Equals("https://www.amazon.com/"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BROWSER/Source.codes.target/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("https://www.youtube.com/"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine(@"
   _____________
  /             \ 
 |      |\\      |
 |      | \\     |
 |      |//      |
  \_____________/
");
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BROWSER/Source.codes.target/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("https://www.apple.com/"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine(@"
          .:'
      __ :'__
   .'`__`-'__``.
  :__________.-'
  :_________:
   :_________`-;
    `.__.-.__.'
");
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BROWSER/Source.codes.target/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("https://lms.ozyegin.edu.tr/"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine(@"
  _______
 /   __  \      ________   |       | 
|   |__| |      \          |       |  
|        |       \         |       | 
 \______/  _______\        |_______| 
");
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BROWSER/Source.codes.target/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else
            {
                Terminal.WriteLine("Please enter valid web site....");
            }
        }
        else if (this.level == 3) {
            if (input.Equals("Jeff Bezos(5262 4751)"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BankAccount/ID.NUM.CV/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("Elon Musk(1237 8617)"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BankAccount/ID.NUM.CV/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("Donald Trump(0054 0001)"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BankAccount/ID.NUM.CV/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("Bill Gates(1104 2000)"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your fist time write a($-->cd/BankAccount/ID.NUM.CV/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else {
                Terminal.WriteLine("Please enter a valid account....");
            }
        }else if (this.level == 4)
        {
            if (input.Equals("USA"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine(@"
 ____________
|::::|_______|
|::::|_______|
|____________|   
|____________|
");
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your first time write a($-->cd/TOPSECRET.file.txt/passwords.txt/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("Turkey"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine(@"
 _________________
|    ___         |
|   |     _/\_   |
|   |    <    >  |
|   |___  \/\/   |
|________________|
");
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your first time write a($-->cd/TOPSECRET.file.txt/passwords.txt/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("England"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your first time write a($-->cd/TOPSECRET.file.txt/passwords.txt/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
            else if (input.Equals("Russai")) {
                Terminal.ClearScreen();
                Terminal.WriteLine("Progress starting....");
                Terminal.WriteLine("Enter necessary command\nIf your first time write a($-->cd/TOPSECRET.file.txt/passwords.txt/hackx.exe)");
                this.currentScreen = Screen.HackingPart;
            }
        }
        
    }
    private void RunHackPart(String input) {
        if (this.level == 1)
        {
            if (input.Equals("$-->cd/SCM/HackFile/hackx.exe"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("hackx.exe start working ....\n10111001101110101011010111001101");
                Terminal.WriteLine("Potantial passwords are with random order:\n1-123deco213\t2-*f**u\n3-12453\t4-wordpass\n5-gamre123AWbCd\t6-7uSrep");
                Terminal.WriteLine("Write your guess:");
                this.currentScreen = Screen.PasswordGuess;
            }
            else
            {
                Terminal.WriteLine("You enter wrong command.");
            }
        }
        else if (this.level == 2)
        {
            if (input.Equals("$-->cd/BROWSER/Source.codes.target/hackx.exe"))
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("hackx.exe start working ....\n<!DOCTYPE html><html><head><body>...<body></head></html>");
                Terminal.WriteLine("Potantial passwords are with random order:\n1-123456NeVeReWGIVeFOR\t2-yeH--zOU\n3-<|3*2=6/2=1+3=4|>\t4-stvAPPPIX00jobs0");
                Terminal.WriteLine("Write your guess:");
                this.currentScreen = Screen.PasswordGuess;
            }
            else
            {
                Terminal.WriteLine("You enter wrong command.");
            }
        }
        else if (this.level == 3)
        {
            if (input.Equals("$-->cd/BankAccount/ID.NUM.CV/hackx.exe"))
            {
                Terminal.WriteLine("hackx.exe start working ....\nID:*******/CV:***/DATE:--/--");
                Terminal.WriteLine("Potantial passwords are with random order:\n1-71809 \t2-14903\n3-94301\t4-00011\n5-7418\t6-4978\n7-3214\t8-5647");
                Terminal.WriteLine("Write your guess:");
                this.currentScreen = Screen.PasswordGuess;
            }
            else
            {
                Terminal.WriteLine("You enter wrong command.");
            }
        }
        else if (this.level == 4) {
            if (input.Equals("$-->cd/TOPSECRET.file.txt/passwords.txt/hackx.exe")) {
                Terminal.WriteLine("hackx.exe start working ....\nAccessing the secret files.");
                Terminal.WriteLine("Potantial passwords are with random order:\n1-11-09/U/A275\t2-T/pSc/INFOS/SS547\n3-t@RT_E874123\t4-*SF9#0V10*TRBT");
                Terminal.WriteLine("Write your guess:");
                this.currentScreen = Screen.PasswordGuess;
            }
            else
            {
                Terminal.WriteLine("You enter wrong command.");
            }
        }
    }
    private void PasswordGuess(String input) {
        if (this.level == 1)
        {
            int num = UnityEngine.Random.Range(0, this.levelOnePasswords.Length);
            string password = this.levelOnePasswords[num];
            if (input == password)
            {
                Terminal.WriteLine("You find it. Congrats you finished the first challenge :) \nIf you want to continue please write 'Menu'");
                this.score = this.score + 100;
                if (this.score > 400)
                {
                    Terminal.WriteLine("Congrats you open the 2nd level :)");
                }
            }
            else
            {
                Terminal.WriteLine("You couldnt find it \nPlease try Again");
            }
        }
        else if (this.level == 2)
        {
            int num = UnityEngine.Random.Range(0, this.levelTwoPasswords.Length);
            string password = this.levelTwoPasswords[num];
            if (input == password)
            {
                Terminal.WriteLine("You find it. Congrats you finished the second challenge :) \nIf you want to continue please write 'Menu'");
                this.score = this.score + 500;
                if (this.score > 3000)
                {
                    Terminal.WriteLine("Congrats you open the 3rd level :)");
                }
            }
            else
            {
                Terminal.WriteLine("You couldnt find it \nPlease try Again");
            }
        }
        else if (this.level == 3)
        {
            int num = UnityEngine.Random.Range(0, this.levelTheerePasswords.Length);
            string password = this.levelTheerePasswords[num];
            if (input == password)
            {
                Terminal.WriteLine("You find it. Congrats you finished the third challenge :) \nIf you want to continue please write 'Menu'");
                this.score = this.score + 1500;
                if (this.score > 15000)
                {
                    Terminal.WriteLine("Congrats you open the 4th level :)");
                }
            }
            else
            {
                Terminal.WriteLine("You couldnt find it \nPlease try Again");
            }
        }
        else if (this.level==4) {
            int num = UnityEngine.Random.Range(0, this.levelFourPasswords.Length);
            string password = this.levelFourPasswords[num];
            if (input == password)
            {
                Terminal.WriteLine("You find it. Congrats you finished the fourth challenge :) \nIf you want to continue please write 'Menu'");
                this.score = this.score + 7500;
                if (this.score > 50000)
                {
                    WinScreen();
                }
            }
            else
            {
                Terminal.WriteLine("You couldnt find it \nPlease try Again");
            }
        }
    }
    private void startGame() {
        this.currentScreen = Screen.HackProgress;
        if (this.level == 1)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Potantials victims are searching.....");
            Terminal.WriteLine("Victims are: \n1-Gameuser123 \t2-GreatSpacePc\n3-DirtyGirlXxX\t4-asd@123@|_");
            Terminal.WriteLine("Enter a victim name:");
        }
        else if (this.level == 2)
        {
            this.currentScreen = Screen.HackProgress;
            Terminal.ClearScreen();
            Terminal.WriteLine("Potantial Websites\n1-https://www.amazon.com/\t2-https://www.youtube.com/\n3-https://www.apple.com/\t4-https://lms.ozyegin.edu.tr/");
            Terminal.WriteLine("Please select the valid web site:");
        }
        else if (this.level == 3)
        {
            this.currentScreen = Screen.HackProgress;
            Terminal.ClearScreen();
            Terminal.WriteLine("Potantial Bank Accounts\n1-Jeff Bezos(5262 4751)\t2-Elon Musk(1237 8617)\n3-Donald Trump(0054 0001)\t4-Bill Gates(1104 2000)");
            Terminal.WriteLine("Please select a valid Bank account:");
        }
        else if (this.level == 4) {
            this.currentScreen = Screen.HackProgress;
            Terminal.ClearScreen();
            Terminal.WriteLine("Potantial Goverments\n1-USA\t2-Turkey\n3-England\t4-Russai");
            Terminal.WriteLine("Please select a valid Country:");
        }
    }
    private void WinScreen() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Congrats you finished the game\nThanks for playing..");
    }
}
