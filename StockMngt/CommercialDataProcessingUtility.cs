using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgramming.Address_Book;
using System.IO;
using Newtonsoft.Json;
using ConsoleTables;
namespace ObjectOrientedProgramming.StockMngt
{
    class CommercialDataProcessingUtility
    {   /// <summary>
        /// Add The Stocks in The Json File 
        /// </summary>
        /// <returns></returns>
        static String UserName;
        public static getStockInfromation AddStocksInformation()
        {
            AddressBookUtility validation = new AddressBookUtility();
            bool flag;
            int numberofShare, sharePrice;

            getStockInfromation Stocks = new getStockInfromation();
            Console.WriteLine("Enter the Stock Name");
            String StockName = validation.CustomName();
            Stocks.StockName = StockName;
            Console.WriteLine("Enter The Number of share");
            do
            {
                flag = int.TryParse(Console.ReadLine(), out numberofShare);
                if (flag)
                    break;
                Console.WriteLine("Enter the Number Of Share Properly");
            } while (!flag);
            Stocks.Numberofshare = numberofShare;
            Console.WriteLine("Enter The Share Price");
            do
            {
                flag = int.TryParse(Console.ReadLine(), out sharePrice);
                if (flag)
                    break;
                Console.WriteLine("Enter the Share Price Properly");
            } while (!flag);

            Stocks.shareprice = sharePrice;
            return Stocks;
        }
        /// <summary>
        /// Create A User Account
        /// </summary>
        public void CreateAccount()
        {
            try
            {
                bool flag = false;
                AddressBookUtility validation = new AddressBookUtility();
                string AccountHoldersPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\AccountHolders.json";
                string AccountHolders = File.ReadAllText(AccountHoldersPath);
                var jsonAccountHolder = JsonConvert.DeserializeObject<AccountHolderLists>(AccountHolders);




                List<CreateAccountUserInfo> Users;
                CreateAccountUserInfo User;
                User = new CreateAccountUserInfo();
                Random _id = new Random();
                User.userID = _id.Next(0000000, 9999999);
                Console.WriteLine("Enter the User Name");
                string userName = validation.CustomName();
                User.userName = userName;
                foreach (var checkuser in jsonAccountHolder.TotalUsers)
                {
                    if (checkuser.userName.Contains(userName))
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("User Name already  Taken Please Try Other");
                }
                else
                {
                    if (AccountHolders == "")
                    {
                        Users = new List<CreateAccountUserInfo>();
                        Users.Add(User);
                    }
                    else
                    {
                        Users = jsonAccountHolder.TotalUsers;
                        Users.Add(User);
                    }

                    AccountHolderLists TotalUser = new AccountHolderLists()
                    {
                        TotalUsers = Users
                    };
                    string TotalUsers = JsonConvert.SerializeObject(TotalUser);
                    File.WriteAllText(AccountHoldersPath, TotalUsers);
                }

            }
            catch (Exception e)
            {

            }
        }

        public void Login()
        {
            bool flag = false;
            int choice;
            char input;

            AddressBookUtility validation = new AddressBookUtility();
            string AccountHoldersPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\AccountHolders.json";
            string AccountHolders = File.ReadAllText(AccountHoldersPath);
            var jsonAccountHolder = JsonConvert.DeserializeObject<AccountHolderLists>(AccountHolders);
            Console.WriteLine("Enter Your User Name");
            UserName = validation.CustomName();
            foreach (var checkUser in jsonAccountHolder.TotalUsers)
            {
                if (checkUser.userName.Contains(UserName))
                {
                    do
                    {
                        Console.WriteLine("_____________________________ Welcome To Commercial data processing ____________________________");
                        Console.WriteLine("1 Buy Share");
                        Console.WriteLine("2 Sell Share");
                        Console.WriteLine("3 Total value");
                        Console.WriteLine("4 Print Report");
                        Console.WriteLine("_____________________________ ************************************* ____________________________");

                        Console.WriteLine("Enter Your Choice");
                        choice = Utility.switchinputvalidation();
                        switch (choice)
                        {
                            case 1:
                                CommercialDataProcessingUtility Buy = new CommercialDataProcessingUtility();
                                Buy.BuyShare();
                                break;
                            case 2:
                                CommercialDataProcessingUtility Shell = new CommercialDataProcessingUtility();
                                Shell.shellShare();
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("You Enterd The Wrong Option");
                                break;
                        }
                        do
                        {
                            Console.WriteLine("Do You Want Continue Y/N ?");
                            flag = char.TryParse(Console.ReadLine(), out input);
                            if (flag)
                                break;
                            Console.WriteLine("Please Enter the proper Input");
                        } while (!flag);

                    } while (input.Equals('y') || input.Equals('Y'));


                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No User Name Found");
            }
        }
        /// <summary>
        /// User Buy shares 
        /// </summary>
        public void BuyShare()
        {
            try
            {
                int serial = 1;
                string buysharePath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\BuyShares.json";
                string PortfolioPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\Portfolio.json";
                string PortfolioData = File.ReadAllText(PortfolioPath);
                var jsonAccountHolder = JsonConvert.DeserializeObject<Portfolio>(PortfolioData);
                Console.WriteLine("You have Avaliable Stocks ...");
                Console.WriteLine();
                var table = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice", "TotalValueofTheStock");


                foreach (var stockData in jsonAccountHolder.TotalStocks)
                {
                    table.AddRow(serial, stockData.StockName, stockData.Numberofshare, stockData.shareprice, stockData.Numberofshare * stockData.shareprice);
                    serial++;
                }
                table.Write();
                Console.WriteLine();
                Console.WriteLine("Enter the StockName to Buy the Share ");
                string Choice = Console.ReadLine();
                var table1 = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice", "TotalValueofTheStock");
                Console.WriteLine("You Selected The " + Choice);
                foreach (var stockData in jsonAccountHolder.TotalStocks)
                {
                    if (stockData.StockName.Contains(Choice))
                    {
                        table1.AddRow(serial, stockData.StockName, stockData.Numberofshare, stockData.shareprice, stockData.Numberofshare * stockData.shareprice);
                        serial++;
                        table1.Write();
                        Console.WriteLine();
                        Console.WriteLine("Enter the how Much Amout of Share You want to Buy");
                        int AmountofShare = Utility.switchinputvalidation();
                        string StockName = stockData.StockName;
                        float NumberofShare = AmountofShare / stockData.shareprice;

                        Console.WriteLine("Amount " + AmountofShare);
                        Console.WriteLine("The Number of Share " + NumberofShare);
                        Console.WriteLine("The Stock Name" + StockName);
                        Console.WriteLine("User " +UserName);
                        DateTime transcationDate = DateTime.Now;
                        Console.WriteLine("Date " +transcationDate);

                        List<Buyshareinfo> BuysShares;
                        Buyshareinfo buyShare = new Buyshareinfo();
                        buyShare.userName = UserName;
                        buyShare.StockName = StockName;
                        buyShare.shareprice = AmountofShare;
                        buyShare.numberofshare = NumberofShare;
                        buyShare.dateAndTime = transcationDate.ToString();
                        string buysharedata = File.ReadAllText(buysharePath);
                        var buysharejsondata = JsonConvert.DeserializeObject<BuyShareList>(buysharedata);

                        if (buysharedata == "")
                        {
                            BuysShares = new List<Buyshareinfo>();
                            BuysShares.Add(buyShare);
                        }
                        else
                        {
                            BuysShares = buysharejsondata.Buysahres;
                            BuysShares.Add(buyShare);
                        }


                        BuyShareList BuyList = new BuyShareList()
                        {
                            Buysahres = BuysShares
                        };

                        string Buysahrelist = JsonConvert.SerializeObject(BuyList);
                        File.WriteAllText(buysharePath, Buysahrelist);


                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void shellShare()
        {
            int serial = 1;
            bool flag = false;
            string shellsharepath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\BuyShares.json";
            string sellsharedata = File.ReadAllText(shellsharepath);
            var shellsharejsondata = JsonConvert.DeserializeObject<BuyShareList>(sellsharedata);

            var table = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice","Transcation Date");


            foreach (var checkuser in shellsharejsondata.Buysahres)
            {
                if (checkuser.userName.Contains(UserName))
                {
                    table.AddRow(serial,checkuser.StockName, checkuser.numberofshare, checkuser.shareprice, checkuser.dateAndTime);
                    serial++;
                    flag = true;
                }
            }
            table.Write();
            Console.WriteLine();

            if (flag==false)
            {
                Console.WriteLine("No any Transcation Done");
            }
        }
    }
}
