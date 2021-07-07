using System;

namespace UserSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[,] userTable = new string[4, 2];

            // main loop
            while (command != "end")
            {
                string[] commandArgs = command.Split(" ");
                switch (commandArgs[0])
                {
                    case "register":
                        {
                            Register(userTable, commandArgs);
                            break;
                        }
                    case "delete":
                        {
                            Delete(userTable, commandArgs);
                            break;
                        }

                }
                Console.ResetColor();
                // read next command
                command = Console.ReadLine();
            }
        }

        // Methods for the two cases Register and Deleting With, nested methods for checks and nested method for the Printing, creating account and deleting account

        private static void Delete(string[,] userTable, string[] commandArgs)
        {
            // validate arguments
            if (IsValideArgumentCheck(commandArgs)) return;

            string username = commandArgs[1];
            string password = commandArgs[2];

            // validate username
            if (IsValidateUserNameChecked(username)) return;

            // validate password
            if (IsPasswordValidateCheck(password)) return;

            // find account to delete
            int accountIndex = AccountIndex(userTable, username, password);

            // check if acount index is negative
            if (IsAccountIdexNegative(accountIndex)) return;

            // delete the user method
            DeleteUser(userTable, accountIndex, username, password);

            // print the deleted user;
            PrintWhenDeleteUser();
            return;

        }

        private static void Register(string[,] userTable, string[] commandArgs)
        {
            {
                // validate arguments
                if (IsValideArgumentCheck(commandArgs)) return;

                string username = commandArgs[1];
                string password = commandArgs[2];

                // validate username
                if (IsValidateUserNameChecked(username)) return;

                // validate password
                if (IsPasswordValidateCheck(password)) return;

                // check if username exists
                if (IsUsernameExist(userTable, username)) return;

                // find free slot
                int freeSlotIndex = FindFreeSlot(userTable);

                // no free slots
                if (IsFreeSlotsCheck(freeSlotIndex)) return;

                // save user
                SaveUser(userTable, freeSlotIndex, username, password);

                // print the saved user;
                PrintWhenSaveUser();
                return;
            }
        }

        // All checks for register and delete account with nested methods from Print methods. 

        private static bool IsAccountIdexNegative(int accountIndex)
        {
            if (accountIndex == -1)
            {
                PrintAcountIdexEqualToMinusOne();
                return true;
            }
            return false;
        }

        private static bool IsFreeSlotsCheck(int freeSlotIndex)
        {
            if (freeSlotIndex == -1)
            {
                PrintIfNoFreeSlots();
                return true;
            }
            return false;
        }

        private static bool IsPasswordValidateCheck(string password)
        {
            if (password.Length < 3)
            {
                PrintValidatePassword();
                return true;
            }
            return false;
        }

        private static bool IsValidateUserNameChecked(string username)
        {
            if (username.Length < 3)
            {
                PrintValidateUsername();
                return true;
            }
            return false;
        }

        private static bool IsValideArgumentCheck(string[] commandArgs)
        {
            if (commandArgs.Length < 3)
            {
                PrintValidateArgument();
                return true;
            }
            return false;
        }

        // Methods for create and delete account and methods that don't need to be reused in this Task/Context

        private static void DeleteUser(string[,] userTable, int accountIndex, string username, string password)
        {
            userTable[accountIndex, 0] = null;
            userTable[accountIndex, 1] = null;
        }

        private static int AccountIndex(string[,] userTable, string username, string password)
        {
            int accountIndex = -1;
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username &&
                    userTable[i, 1] == password)
                {
                    accountIndex = i;
                }
            }
            return accountIndex;
        }

        private static void SaveUser(string[,] userTable, int freeSlotIndex, string username, string password)
        {
            userTable[freeSlotIndex, 0] = username;
            userTable[freeSlotIndex, 1] = password;
        }

        private static int FindFreeSlot(string[,] userTable)
        {
            int freeSlotIndex = -1;
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == null)
                {
                    return i;
                }
            }
            return freeSlotIndex;
        }

        private static bool IsUsernameExist(string[,] userTable, string username)
        {
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username)
                {
                    return true;
                }
            }
            return false;
        }


        //Printing and Validating methods for REUSE THEM - DONE The methods are working
        private static void PrintAcountIdexEqualToMinusOne()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid account/password.");
        }

        private static void PrintWhenDeleteUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Deleted account.");
        }

        private static void PrintWhenSaveUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Registered user.");
        }

        private static void PrintIfNoFreeSlots()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The system supports a maximum number of 4 users.");
        }

        private static void PrintIfValidateExist()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Username already exists.");
        }

        private static void PrintValidatePassword()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must be at least 3 characters long.");
        }

        private static void PrintValidateUsername()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Username must be at least 3 characters long.");
        }

        private static void PrintValidateArgument()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Too few parameters.");
        }
    }
}
