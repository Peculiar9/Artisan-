
using System;

namespace banking
{

	class Program
	{
		static string name, mname, lname;	//GLOBAL VARIABLE DECLARATION
		static int day, month, year, loanop, option, moveon, required, op, fundnew, user, adeop, pinade;
		static double newb, newb2, amount, balance, loanam, deposit;
		static float funding = 2000f;



		static void welcome()
		{	//FUNCTION FOR THE MAIN MENU


			Console.WriteLine("   ");
			Console.WriteLine("Welcome to artisan local bank");
			Console.WriteLine("     ");
			Console.WriteLine("Press 1 to Create an account");
			Console.WriteLine("     ");
			Console.WriteLine("Press 2 to Deposit");
			Console.WriteLine("     ");
			Console.WriteLine("Press 3 to apply for a loan");
			Console.WriteLine("     ");
			Console.WriteLine("Press 4 to login as an existing user");
			option = int.Parse(Console.ReadLine());
			if (option == 1)
			{
				biodata();
			}
			else if (option == 2)
			{
				Console.WriteLine("     ");
				Console.WriteLine("Deposit menu");
				loginrequired();
			}
			else if (option == 3)
			{
				Console.WriteLine("     ");
				Console.WriteLine("Loan menu");
				loanmenu();
			}
			else if (option == 4)
			{
				Console.WriteLine("     ");
				existuser();
			}
			else
			{
				Console.WriteLine("Invalid input");
			}



		}

		public static void biodata()
		{
			Console.WriteLine("   ");													//FUNCTION THAT HANDLES REGISTRATION
			Console.WriteLine("Welcome back! Please fill in your biodatas Appropriately");
			Console.WriteLine("Enter First name");
			name = Console.ReadLine();
			Console.WriteLine("Enter Last name");
			lname = Console.ReadLine();

			Console.WriteLine("Enter mother's maiden name");
			mname = Console.ReadLine();
			Console.WriteLine("Day of Birth");
			day = int.Parse(Console.ReadLine());
			Console.WriteLine("Month of Birth");
			month = int.Parse(Console.ReadLine());
			Console.WriteLine("Year of birth");
			year = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter first deposit amount");
			amount = float.Parse(Console.ReadLine());

			Console.WriteLine("     ");
			Console.WriteLine("     ");

			Console.WriteLine("Kindly crosscheck the information you entered");
			Console.WriteLine("     ");
			Console.WriteLine("Full name :- {0} {1}", name, lname);
			Console.WriteLine("     ");
			Console.WriteLine("Mother's maiden name' :- {0}", mname);
			Console.WriteLine("     ");
			Console.WriteLine("Date Of Birth :- {0}-{1}-{2}", day, month, year);
			Console.WriteLine("     ");
			Console.WriteLine("Opening Balance :- {0} ", amount);


			Console.WriteLine("     ");
			Console.WriteLine("     ");


			Console.WriteLine("Press 1 to make a deposit");
			Console.WriteLine("     ");
			Console.WriteLine("Press 2 to apply for a loan");
			moveon = int.Parse(Console.ReadLine());

			if (moveon == 1)
			{
				Console.WriteLine("Transferring to Deposit menu.......");
				depositmenu();
			}
			else if (moveon == 2)
			{
				loanmenu();
			}

		}


		public static void depositmenu()
		{												//FUNCTION THAT HANDLES DEPOSIT
			Console.WriteLine("Welcome to the deposit menu");
			Console.WriteLine("     ");
			Console.WriteLine("Your current balance is :- #{0} ", deposit);
			Console.WriteLine("     ");
			Console.WriteLine("To make a deposit press 1");
			Console.WriteLine("     ");
			Console.WriteLine("To apply for loan press 2");
			Console.WriteLine("     ");
			Console.WriteLine("Go back to main menu");
			op = int.Parse(Console.ReadLine());

			switch (op)
			{
				case 1:
					Console.WriteLine("Welcome to deposit menu");
					Console.WriteLine("   ");
					Console.WriteLine("Enter deposit amount");
					float amount = float.Parse(Console.ReadLine());
					Console.WriteLine("     ");
					Console.WriteLine("     ");
					newb = deposit + amount;
					Console.WriteLine("   ");
					Console.WriteLine("Your new balance is :- # {0} ", newb);
					break;
				case 2: loanmenu();
					break;
				case 3:

					Console.ReadKey();
					break;
				default: Console.WriteLine(" Error Found!!! ");
					break;
			}
		}





		   static void loanmenu(){											//FUNCTION FOR THE LOAN MENU
				Console.WriteLine("    ");
				Console.WriteLine("welcome to loan menu");
				Console.WriteLine("   ");
				Console.WriteLine("To apply for a loan you must meet the following requirement!!");
				Console.WriteLine("   ");
				Console.WriteLine("You must have at least "+funding+" in your account");
				Console.WriteLine("   ");
				Console.WriteLine("To continue press 1");
				Console.WriteLine("   ");
				Console.WriteLine("To exit press 2");
				int loanop = int.Parse(Console.ReadLine());
				if (loanop == 1){
					Console.WriteLine("   ");
					Console.WriteLine("Checking if you meet the loan requirements");
					if (deposit > funding){
						Console.WriteLine("   ");
						Console.WriteLine("you are qualified for the loan");
						Console.WriteLine("   ");
						Console.WriteLine("enter amount of loan you need");
						float loanam = float.Parse(Console.ReadLine());
						newb2= deposit + loanam;
						Console.WriteLine("   ");
						Console.WriteLine("your new balance is :{0}" ,newb2);
					}else {
						Console.WriteLine("   ");
						Console.WriteLine("you don't qualify for a loan");
						Console.WriteLine("   ");
					Console.WriteLine("your current balance is :{0}" ,newb);
					Console.WriteLine("   ");
					Console.WriteLine("you need a minimum of  # {0} funding to apply for a loan", funding);
					Console.WriteLine("   ");
					Console.WriteLine("To make a deposit press 1");
					Console.WriteLine("   ");
					Console.WriteLine("To exit press 2");
					int fundnew = int.Parse(Console.ReadLine());
					if (fundnew == 1){
						loginrequired();
					}
					else if (fundnew == 2){
						Console.ReadKey();
					}
					}
				}
				else if (loanop == 2){

					Console.ReadKey();
				}


			}

		public static void loginrequired()
		{												//FUNCTION FOR CHECKING IF USER IS REGISTERED
			Console.WriteLine("   ");
			Console.WriteLine("YOU NEED TO HAVE AN ACCOUNT BEFORE YOU CAN PERFORM THIS OPERATION!!!");
			Console.WriteLine("   ");
			Console.WriteLine("Press 1 to go to registration");
			Console.WriteLine("   ");
			Console.WriteLine("Press 2 to exit");
			required = int.Parse(Console.ReadLine());
			if (required == 1)
			{
				biodata();
			}
			else if (required == 2)
			{
				Console.ReadKey();
			}
			welcome();
		}

		public static void existuser()
		{
			Console.WriteLine("WELCOME TO THE EXISTING USER'S PROFILE");
			Console.WriteLine("1. Mr    Ade", "      ", "Access code:- ", "7782");
			Console.WriteLine("   \n\n ");
			

			Console.WriteLine("To access an existing user");
			Console.WriteLine("Enter the specific user code");
			user = int.Parse(Console.ReadLine());
			switch (user)
			{
				case 7782: // Beginning of case
					Console.WriteLine("Welcome Mr ade");
					Console.WriteLine("To Continue enter your Secret pin ****");
					int pinade = int.Parse(Console.ReadLine());
					if (pinade == 5995)
					{
						Console.WriteLine("Pin Accepted");
						Console.WriteLine("Welcome Back Mr ade");
						Console.WriteLine("Press 1 to make a deposit");
						Console.WriteLine("    ");
						Console.WriteLine("Press 2 to make apply for a loan");
						Console.WriteLine("    ");
						Console.WriteLine("Press 3 to check your transaction history");
						adeop = int.Parse(Console.ReadLine());
						switch (adeop)
						{
							case 1:
								depositmenu();
								break;
							case 2:
								loanmenu();
								break;
							case 3:
								Console.WriteLine("Welcome to your account history/statement");
								Console.WriteLine("    ");
								Console.WriteLine("1. Registered on MAY-6-2019");
								Console.WriteLine("    ");
								Console.WriteLine("2. Deposited #1200 on MAY-19-2019");
								Console.WriteLine("    ");
								Console.WriteLine("3. Transferred #400 to user4523");
								Console.WriteLine("    ");
								welcome();
								break;
							case 4:
								Console.WriteLine("Invalid input");
								Console.WriteLine("Transferring to main menu");
								welcome();
								break;

						}
					}
					else
					{
						Console.WriteLine("Invalid pin----exiting");
					}
					break;// The end of the case statement 
			}

		}


		public static void Main(string[] args)
		{	//MAIN FUNCTION THAT HANDLES OTHER FUNCTIONS
			//MAIN ENTRY OF THE PROGRAM

			welcome();

		}


	}
}

