using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Assignment
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        // 1. Gardening Tools
        public Dictionary<int, ToolCollection> gardeningTools = new Dictionary<int, ToolCollection>();
        private ToolCollection lineTrimmers = new ToolCollection();
        private ToolCollection lawnMowers = new ToolCollection();
        private ToolCollection gHandTools = new ToolCollection();
        private ToolCollection wheelbarrows = new ToolCollection();
        private ToolCollection gardenPowerTools = new ToolCollection();

        // 2. Flooring Tools
        public Dictionary<int, ToolCollection> flooringTools = new Dictionary<int, ToolCollection>();
        private ToolCollection scrapers = new ToolCollection();
        private ToolCollection floorLasers = new ToolCollection();
        private ToolCollection floorLevellingTools = new ToolCollection();
        private ToolCollection floorLevellingMaterials = new ToolCollection();
        private ToolCollection floorHandTools = new ToolCollection();
        private ToolCollection tilingTools = new ToolCollection();

        // 3. Fencing Tools
        public Dictionary<int, ToolCollection> fencingTools = new Dictionary<int, ToolCollection>();
        private ToolCollection fHandTools = new ToolCollection();
        private ToolCollection electricFencing = new ToolCollection();
        private ToolCollection steelFencingTools = new ToolCollection();
        private ToolCollection powerTools = new ToolCollection();
        private ToolCollection fencingAccessories = new ToolCollection();

        // 4. Measuring Tools
        public Dictionary<int, ToolCollection> measuringTools = new Dictionary<int, ToolCollection>();
        private ToolCollection distanceTools = new ToolCollection();
        private ToolCollection laserMeasurer = new ToolCollection();
        private ToolCollection measuringJugs = new ToolCollection();
        private ToolCollection tempuratureHumidityTools = new ToolCollection();
        private ToolCollection levellingTools = new ToolCollection();
        private ToolCollection markers = new ToolCollection();

        // 5. Cleaning Tools
        public Dictionary<int, ToolCollection> cleaningTools = new Dictionary<int, ToolCollection>();
        private ToolCollection draining = new ToolCollection();
        private ToolCollection carCleaning = new ToolCollection();
        private ToolCollection vacuum = new ToolCollection();
        private ToolCollection pressureCleaners = new ToolCollection();
        private ToolCollection poolCleaning = new ToolCollection();
        private ToolCollection floorCleaning = new ToolCollection();

        // 6. Painting Tools
        public Dictionary<int, ToolCollection> paintingTools = new Dictionary<int, ToolCollection>();
        private ToolCollection sandingTools = new ToolCollection();
        private ToolCollection brushes = new ToolCollection();
        private ToolCollection rollers = new ToolCollection();
        private ToolCollection paintRemovalTools = new ToolCollection();
        private ToolCollection paintScrapers = new ToolCollection();
        private ToolCollection sprayers = new ToolCollection();

        // 7. Electronic Tools
        public Dictionary<int, ToolCollection> electronicTools = new Dictionary<int, ToolCollection>();
        private ToolCollection voltageTester = new ToolCollection();
        private ToolCollection oscilloscopes = new ToolCollection();
        private ToolCollection thermalImaging = new ToolCollection();
        private ToolCollection dataTestTool = new ToolCollection();
        private ToolCollection insulationTesters = new ToolCollection();

        // 8. Electricity Tools
        public Dictionary<int, ToolCollection> electricityTools = new Dictionary<int, ToolCollection>();
        ToolCollection testEquipment = new ToolCollection();
        ToolCollection safetyEquipment = new ToolCollection();
        ToolCollection basicHandTools = new ToolCollection();
        ToolCollection circuitProtection = new ToolCollection();
        ToolCollection cableTools = new ToolCollection();

        // 9. Automotive Tools
        public Dictionary<int, ToolCollection> automotiveTools = new Dictionary<int, ToolCollection>();
        private ToolCollection jacks = new ToolCollection();
        private ToolCollection airCompressors = new ToolCollection();
        private ToolCollection batteryChargers = new ToolCollection();
        private ToolCollection socketTools = new ToolCollection();
        private ToolCollection braking = new ToolCollection();
        private ToolCollection drivetrain = new ToolCollection();
        
        // Most recently selected sub-category retrieved through the displayCategories() method
        private ToolCollection currentCollection;
        // Array of all borrowed tools (contains duplicates)
        private Tool[] borrowedTools = new Tool[0];
        // Number or maximum possible borrows by a member
        private int maxNumBorrows = 3;

        // Member Collection
        public MemberCollection members = new MemberCollection();
        // Currently logged in member to the system
        public Member currentLoggedMember;

        public ToolLibrarySystem()
        {
            // Constructors for tool categories
            // 1. Gardening Tools
            gardeningTools.Add(1, lineTrimmers);
            gardeningTools.Add(2, lawnMowers);
            gardeningTools.Add(3, gHandTools);
            gardeningTools.Add(4, wheelbarrows);
            gardeningTools.Add(5, gardenPowerTools);

            // 2. Flooring Tools
            flooringTools.Add(1, scrapers);
            flooringTools.Add(2, floorLasers);
            flooringTools.Add(3, floorLevellingTools);
            flooringTools.Add(4, floorLevellingMaterials);
            flooringTools.Add(5, floorHandTools);
            flooringTools.Add(6, tilingTools);

            // 3. Fencing Tools
            fencingTools.Add(1, fHandTools);
            fencingTools.Add(2, electricFencing);
            fencingTools.Add(3, steelFencingTools);
            fencingTools.Add(4, powerTools);
            fencingTools.Add(5, fencingAccessories);

            // 4. Measuring Tools
            measuringTools.Add(1, distanceTools);
            measuringTools.Add(2, laserMeasurer);
            measuringTools.Add(3, measuringJugs);
            measuringTools.Add(4, tempuratureHumidityTools);
            measuringTools.Add(5, levellingTools);
            measuringTools.Add(6, markers);

            // 5. Cleaning Tools
            cleaningTools.Add(1, draining);
            cleaningTools.Add(2, carCleaning);
            cleaningTools.Add(3, vacuum);
            cleaningTools.Add(4, pressureCleaners);
            cleaningTools.Add(5, poolCleaning);
            cleaningTools.Add(6, floorCleaning);

            // 6. Painting Tools
            paintingTools.Add(1, sandingTools);
            paintingTools.Add(2, brushes);
            paintingTools.Add(3, rollers);
            paintingTools.Add(4, paintRemovalTools);
            paintingTools.Add(5, paintScrapers);
            paintingTools.Add(6, sprayers);

            // 7. Electronic Tools
            electronicTools.Add(1, voltageTester);
            electronicTools.Add(2, oscilloscopes);
            electronicTools.Add(3, thermalImaging);
            electronicTools.Add(4, dataTestTool);
            electronicTools.Add(5, insulationTesters);

            // 8. Electricity Tools
            electricityTools.Add(1, testEquipment);
            electricityTools.Add(2, safetyEquipment);
            electricityTools.Add(3, basicHandTools);
            electricityTools.Add(4, circuitProtection);
            electricityTools.Add(5, cableTools);

            // 9. Automotive Tools
            automotiveTools.Add(1, jacks);
            automotiveTools.Add(2, airCompressors);
            automotiveTools.Add(3, batteryChargers);
            automotiveTools.Add(4, socketTools);
            automotiveTools.Add(5, braking);
            automotiveTools.Add(6, drivetrain);

            // Start the system after everything has been initialized
            MainMenu();
        }

        // Add the given tool to the system using currentCollection
        public void add(Tool aTool)
        {
            currentCollection.add(aTool);
        }

        // increase the quantity of a specified tool
        public void add(Tool aTool, int quantity)
        {
            aTool.Quantity += quantity;
        }

        // Adds the given member to the MemberCollection
        public void add(Member aMember)
        {
            members.add(aMember);
        }        

        // Deletes the given tool from the currentCollection
        public void delete(Tool aTool)
        {
            currentCollection.delete(aTool);
        }

        // Deletes the specified quantity from the given tool from currentCollection
        public void delete(Tool aTool, int quantity)
        {
            if ((aTool.Quantity - quantity) <= 0)
                delete(aTool);
            else
                aTool.Quantity -= quantity;
        }

        // Deletes the given member from MemberCollection
        public void delete(Member aMember)
        {
            members.delete(aMember);
        }

        // Display all tools borrowed by currentLoggedMember
        public void displayBorrowingTools(Member aMember)
        {
            string[] memberTools = listTools(aMember);
            if (memberTools.Length == 0)
                Console.WriteLine("No tools borrowed.");
            else
            {
                Console.WriteLine("Current borrowed tools for " + aMember.FirstName + ":");
                for (int j = 0; j < memberTools.Length; ++j)
                    Console.WriteLine("\t" + (j + 1) + ". " + memberTools[j]);
            }
            Console.WriteLine();
        }

        // Write to the console the given tool name 
        public void displayTools(string aToolType)
        {
            Console.WriteLine(aToolType);
        }       

        // Adds the given tool to currentLoggedMember's ToolCollection of borrowed tools
        public void borrowTool(Member aMember, Tool aTool)
        {
            --aTool.AvailableQuantity;
            aMember.addTool(aTool);
            aTool.addBorrower(aMember);
            borrowedTools = insertTools(borrowedTools, aTool);
        }

        // Removes the given tool from currentLoggedMember's borrowed tools
        public void returnTool(Member aMember, Tool aTool)
        {
            ++aTool.AvailableQuantity;
            aMember.deleteTool(aTool);
            aTool.deleteBorrower(aMember);
        }

        // Did not need this method as displayBorrowingTools() is almost
        public string[] listTools(Member aMember)
        {
            string[] borrowedTools = new string[aMember.Tools.Length];
            for (int i = 0; i < borrowedTools.Length; ++i)
            {
                borrowedTools[i] = aMember.Tools[i].Name;
            }
            return borrowedTools;
        }

        // Write the top 3 most frequently borrowed tools to the console
        public void displayTopThree()
        {
            if (borrowedTools.Length > 0)
            {
                // Sort borrowedTools by most frequently borrowed
                InsertionSort(borrowedTools);
                Tool[] topThree = new Tool[3];
                // Filter out any duplicates in borrowed tools and the top three to topThree
                for (int i = 0; i < topThree.Length; ++i)
                    for (int j = 0; j < borrowedTools.Length; ++j)
                    {
                        if (i == 0)
                        {
                            topThree[i] = borrowedTools[j];
                            break;
                        }
                        else if (i == 1 && topThree[i] == null && topThree[0] != null && !topThree[0].Name.Equals(borrowedTools[j].Name))
                        {
                            topThree[i] = borrowedTools[j];
                            break;
                        }
                        else if (i == 2 && topThree[i] == null && topThree[0] != null && topThree[1] != null && !topThree[1].Name.Equals(borrowedTools[j].Name) && !topThree[0].Name.Equals(borrowedTools[j].Name))
                        {
                            topThree[i] = borrowedTools[j];
                            break;
                        }
                    }
                Console.WriteLine("The top 3 most frequently borrowed tools:");
                for (int i = 0; i < topThree.Length; ++i)
                {
                    Tool currentTool = topThree[i];
                    if(currentTool != null)
                        Console.WriteLine("\t" + (i + 1) + ". Name: " + currentTool.Name + ", Times Borrowed: " + currentTool.NoBorrowings);
                    else
                        Console.WriteLine("\t" + (i + 1) + ". Name: -, Times Borrowed: -");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No tools borrowed yet.\n");
            }
        }

        //----------------------------------------------------------------------------
        // MENUS
        private void MainMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===========Main Menu===========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===============================\n");
            Console.Write("Please make a selection (1-2, or 0 to exit): ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    StaffLogin();
                    break;
                case "2":
                    MemberLogin();
                    break;
                case "0":
                    Console.WriteLine("Closing System...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.\n");
                    MainMenu();
                    break;
            }
        }

        // Staff Menus
        private void StaffMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===========Staff Menu===========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of equipment");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("================================\n");
            Console.Write("Please make a selection (1-6, or 0 to return to main menu): ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    StaffAddTool();
                    StaffMenu();
                    break;
                case "2":
                    StaffAddExistingTool();
                    StaffMenu();
                    break;
                case "3":
                    StaffRemoveTool();
                    StaffMenu();
                    break;
                case "4":
                    StaffAddMember();
                    StaffMenu();
                    break;
                case "5":
                    StaffRemoveMember();
                    StaffMenu();
                    break;
                case "6":
                    StaffGetContact();
                    StaffMenu();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.\n");
                    StaffMenu();
                    break;
            }
        }

        // Prompt the user to enter the staff username and password: "staff", "today123"
        void StaffLogin()
        {
            Member[] currentMembers = members.toArray();
            Console.WriteLine("Staff Login");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine();
            if (username == "staff" && password == "today123")
            {
                Console.WriteLine("Logged in successfully!\n");
                StaffMenu();
            }
            else
            {
                Console.WriteLine("Invalid login details.\n");
                MainMenu();
            }
        }

        // Prompt the user with a list of categories to navigate through, ask for a name
        // and quantity, then add the tool to the category specified
        private void StaffAddTool()
        {
            try
            {
                displayCategories();
                Tool newTool = new Tool();
                Console.Write("\nEnter tool name: ");
                newTool.Name = Console.ReadLine().Trim();
                try
                {
                    Console.Write("Enter quantity(number only): ");
                    newTool.Quantity = Convert.ToInt32(Console.ReadLine());
                    add(newTool);
                    Console.WriteLine("\nTool '" + newTool.Name + "' added successfully.\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid number.\n");
                }
            }
            catch (Exception )
            {
                Console.WriteLine("\nInvalid option, try again.\n");
                StaffMenu();
            }
        }

        // Prompt the user with a list of categories to navigate through to retrieve an
        // an item then ask for a quantity, adding the number entered to the total of the item
        private void StaffAddExistingTool()
        {
            try
            {
                displayCategories();
                Tool[] tools = currentCollection.toArray();
                if (displayTool(tools))
                {
                    try
                    {
                        Console.Write("Enter the number corresponing to the tool you wish to increment: ");
                        int toolNum = Convert.ToInt16(Console.ReadLine());
                        Tool chosenTool = tools[toolNum - 1];
                        Console.Write("\nEnter quantity to add: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        add(chosenTool, quantity);
                        Console.WriteLine("\nAdded '" + quantity + "' " + chosenTool.Name + "(s). '" + chosenTool.Quantity + "' total.\n");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid number.\n");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid option, try again.\n");
            }
        }

        // Prompt the user with a list of categories to navigate through, then
        // remove the tool corresponding to the numerical value entered
        private void StaffRemoveTool()
        {
            try
            {
                displayCategories();
                Tool[] tools = currentCollection.toArray();
                if (displayTool(tools))
                {
                    try
                    {
                        Console.Write("Enter the number corresponing to the tool you wish to remove: ");
                        int toolNum = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nEnter quantity to remove: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Tool chosenTool = tools[toolNum - 1];
                        int remainder = chosenTool.Quantity - quantity;
                        bool fewerThanZero = (remainder <= 0);
                        Console.WriteLine("\nRemoved " + (fewerThanZero ? "all" : Convert.ToString(quantity)) + " " + chosenTool.Name + "(s)." + (fewerThanZero ? "" : " " + remainder + " remaining.") + "\n");
                        delete(chosenTool, quantity);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid number.\n");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid option, try again.\n");
            }
        }

        // Prompt the user for a fist and last name, contact number, 
        // and PIN then create a member with those details
        private void StaffAddMember()
        {
            Member newMember = new Member();
            Console.Write("Enter first name: ");
            newMember.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            newMember.LastName = Console.ReadLine();
            Console.Write("Enter contact number: ");
            newMember.ContactNumber = Console.ReadLine();
            Console.Write("Enter PIN: ");
            newMember.PIN = Console.ReadLine();
            add(newMember);
            Console.WriteLine("\nMember '" + newMember.FirstName + "' added successfully.\n");
        }

        // Prompt the user with all currently registered members and ask for a number,
        // delete the member corresponding to the number
        private void StaffRemoveMember()
        {
            Member[] currentMembers = members.toArray();
            if (displayMembers(currentMembers))
            {
                Console.Write("Enter the number corresponing to the member you wish to remove: ");
                int memberNum = Convert.ToInt16(Console.ReadLine());
                Member chosenMember = currentMembers[memberNum - 1];
                try
                {
                    delete(chosenMember);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid number.");
                }
            }            
            Console.WriteLine();
        }

        // Prompt the user to write a member's first and last name to retrieve their contact
        private void StaffGetContact()
        {
            Member[] currentMembers = members.toArray();            
            if (currentMembers.Length == 0)
                Console.WriteLine("No members to display.");
            else
            {
                string returnLine = "No member found by that name.";
                Console.Write("Enter the the member's first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter the the member's last name: ");
                string lastName = Console.ReadLine();
                for (int i = 0; i < currentMembers.Length; ++i)
                    if (currentMembers[i].FirstName == firstName && currentMembers[i].LastName == lastName)
                        returnLine = firstName + "'s contact number is: " + currentMembers[i].ContactNumber;
                Console.WriteLine("\n" + returnLine);
            }
            Console.WriteLine();
        }

        // Member Menus
        private void MemberMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===========Member Menu===========");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequently rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("=================================\n");
            Console.Write("Please make a selection (1-5, or 0 to return to main menu): ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    MemberDisplayTools();
                    MemberMenu();
                    break;
                case "2":
                    MemberBorrowTool();
                    MemberMenu();
                    break;
                case "3":
                    MemberReturnTool();
                    MemberMenu();
                    break;
                case "4":
                    MemberDisplayBorrowed();
                    MemberMenu();
                    break;
                case "5":
                    MemberDisplayTopThree();
                    MemberMenu();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.\n");
                    MemberMenu();
                    break;
            }
        }

        // Prompt the user to write this first and last name along with their PIN to log in
        void MemberLogin()
        {
            Member[] currentMembers = members.toArray();
            Console.WriteLine("Member Login");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your pin: ");
            string pin = Console.ReadLine();
            Console.WriteLine();
            for(int i = 0; i < currentMembers.Length; ++i)
                if (currentMembers[i].FirstName == firstName && currentMembers[i].LastName == lastName && currentMembers[i].PIN == pin)
                    currentLoggedMember = currentMembers[i];
            if (currentLoggedMember == null)
            {
                Console.WriteLine("Invalid login details.\n");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Logged in successfully!\n");
                MemberMenu();
            }
                
        }

        // Prompt the user with a list of categories to navigate through to
        // check their inventory
        void MemberDisplayTools()
        {
            try
            {
                displayCategories();
                displayTool(currentCollection.toArray());
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid option, try again.\n");
            }
        }

        // Prompt the user with a list of categories to navigate through,
        // ask for a numerical response and borrow the tools corresponding to the number
        void MemberBorrowTool()
        {
            if (currentLoggedMember.Tools.Length < maxNumBorrows)
            {
                try
                {
                    displayCategories();
                    Tool[] tools = currentCollection.toArray();
                    if (displayTool(tools))
                    {
                        Console.Write("\nEnter the name of the tool you wish to borrow: ");
                        string toolName = Console.ReadLine();
                        string returnPhrase = "No tools found by that name.";
                        for (int i = 0; i < tools.Length; ++i)
                        {
                            Tool tool = tools[i];
                            if (tool.Name == toolName && tool.AvailableQuantity <= 0)
                            {
                                returnPhrase = "No available " + tool.Name + "(s) to borrow.";
                                break;
                            }
                            else if (tool.Name == toolName && tool.AvailableQuantity > 0)
                            {
                                borrowTool(currentLoggedMember, tools[i]);
                                returnPhrase = "You have borrowed a '" + tool.Name + "'.\n";
                                ++tool.NoBorrowings;
                                break;
                            }
                        }
                        Console.WriteLine(returnPhrase + "\n");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("\nInvalid option, try again.\n");
                }
            }
            else
            {
                Console.WriteLine("\nYou cannot borrowed anymore tools.\n");
            }
        }

        // Prompt the user with a list of borrowed tools and ask for a 
        // numerical response, returnign the item corresponding to the number
        void MemberReturnTool()
        {
            try
            {
                Tool[] tools = currentLoggedMember.Tools;
                Console.WriteLine("Current borrowed tools for " + currentLoggedMember.FirstName + ":");
                if(tools.Length > 0)
                {
                    for (int i = 0; i < tools.Length; ++i)
                        Console.WriteLine("\t" + (i + 1) + ". " + tools[i].Name);
                    Console.Write("Enter the number associated with the tool to return: ");
                    int toolNum = Convert.ToInt16(Console.ReadLine());
                    Tool tool = tools[toolNum - 1];
                    returnTool(currentLoggedMember, tool);
                    Console.WriteLine("\nYou have returned " + tool + ".\n");
                }
                else
                {
                    Console.WriteLine("\tNo tools to return.\n");
                    MemberMenu();
                }                
            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid number.\n");
            }           
        }
        
        // Call displayBorrowingTools() using currentLoggedMember
        void MemberDisplayBorrowed()
        {
            displayBorrowingTools(currentLoggedMember);
        }

        // Call displayTopThree()
        void MemberDisplayTopThree()
        {            
            displayTopThree();
        }

        //---------------------------------------------------------------
        // HELPER METHODS

        // Display all given members to the console
        private bool displayMembers(Member[] members)
        {
            Console.WriteLine("Current registered members:");
            if (members.Length == 0)
            {
                Console.WriteLine("\tNo members to display.");
                return false;
            }
            else
            {
                for (int i = 0; i < members.Length; ++i)
                    Console.WriteLine("\t" + (i + 1) + ". " + members[i].LastName + ", " + members[i].FirstName);
                return true;
            }            
        }

        // Display all tools given to the console
        private bool displayTool(Tool[] tools)
        {
            Console.WriteLine("\nCurrent inventory of selected category:");
            if (tools.Length == 0)
            {
                Console.WriteLine("\tNo tools to display.\n");
                return false;
            }
            else
            {
                for (int i = 0; i < tools.Length; ++i)
                {
                    Console.Write("\t" + (i + 1) + ". ");
                    displayTools(tools[i].ToString());
                }
                    
                return true;
            }
        }

        // Writes a seires of menus to the console, guiding the 
        // user through which category they would like to access
        private void displayCategories()
        {
            ToolCollection category = null;
            Console.Write("Select a category: " +
                    "\n\t1. Gardening Tools" +
                    "\n\t2. Flooring Tools" +
                    "\n\t3. Fencing Tools" +
                    "\n\t4. Measuring Tools" +
                    "\n\t5. Cleaning Tools" +
                    "\n\t6. Painting Tools" +
                    "\n\t7. Electronic Tools" +
                    "\n\t8. Elecricity Tools" +
                    "\n\t9. Automotive Tools\n");
            Console.Write("Enter the number corresponding to the category: ");
            int selection1 = Convert.ToInt16(Console.ReadLine());
            int selection2;
            switch (selection1)
            {
                case 1:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Line Trimmers" +
                        "\n\t2. Lawn Mowers" +
                        "\n\t3. Hand Tools" +
                        "\n\t4. Wheelbarrows" +
                        "\n\t5. Garden Power Tools\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    gardeningTools.TryGetValue(selection2, out category);
                    break;
                case 2:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Scrapers" +
                        "\n\t2. Floor Lasers" +
                        "\n\t3. Floor Levelling Tools" +
                        "\n\t4. Floor Levelling Materials" +
                        "\n\t5. Floor Hand Tools" +
                        "\n\t6. Tiling Tools\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    flooringTools.TryGetValue(selection2, out category);
                    break;
                case 3:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Hand Tools" +
                        "\n\t2. Electric Fencing" +
                        "\n\t3. Steel Fencing Tools" +
                        "\n\t4. Power Tools" +
                        "\n\t5. Fencing Accessories\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    fencingTools.TryGetValue(selection2, out category);
                    break;
                case 4:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Distance Tools" +
                        "\n\t2. Laser Measurer" +
                        "\n\t3. Measuring Jugs" +
                        "\n\t4. Temperature & Humidity Tools" +
                        "\n\t5. Levelling Tools" +
                        "\n\t6. Markers\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    measuringTools.TryGetValue(selection2, out category);
                    break;
                case 5:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Draining" +
                        "\n\t2. Car Cleaning" +
                        "\n\t3. Vacuum" +
                        "\n\t4. Pressure Cleaners" +
                        "\n\t5. Pool Cleaning" +
                        "\n\t6. Floor Cleaning\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    cleaningTools.TryGetValue(selection2, out category);
                    break;
                case 6:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Sanding Tools" +
                        "\n\t2. Brushes" +
                        "\n\t3. Rollers" +
                        "\n\t4. Paint Removal Tools" +
                        "\n\t5. Paint Scrapers" +
                        "\n\t6. Sprayers\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    paintingTools.TryGetValue(selection2, out category);
                    break;
                case 7:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Voltage Tester" +
                        "\n\t2. Oscilloscopes" +
                        "\n\t3. Thermal Imaging" +
                        "\n\t4. Data Test Tool" +
                        "\n\t5. Insulation Testers\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    electronicTools.TryGetValue(selection2, out category);
                    break;
                case 8:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Test Equipment" +
                        "\n\t2. Safety Equipment" +
                        "\n\t3. Basic Equipment" +
                        "\n\t4. Circuit Protection" +
                        "\n\t5. Cable Tools\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    electricityTools.TryGetValue(selection2, out category);
                    break;
                case 9:
                    Console.Write("\nSelect a sub-category: " +
                        "\n\t1. Jacks" +
                        "\n\t2. Air Compressors" +
                        "\n\t3. Battery Chargers" +
                        "\n\t4. Socket Tools" +
                        "\n\t5. Braking" +
                        "\n\t6. Drivetrain\n");
                    Console.Write("Enter the number corresponding to the category: ");
                    selection2 = Convert.ToInt16(Console.ReadLine());
                    automotiveTools.TryGetValue(selection2, out category);
                    break;
            }
            if (category == null)
                throw new NullReferenceException();
            else
                currentCollection = category;
        }

        // Given an array of tools and a tool, return an array of 1 size
        // larger with the tool added to the end
        private Tool[] insertTools(Tool[] tools, Tool tool)
        {
            Tool[] resizedTools = new Tool[tools.Length + 1];
            for (int i = 0; i < tools.Length; ++i)
                resizedTools[i] = tools[i];
            resizedTools[resizedTools.Length - 1] = tool;
            return resizedTools;
        }

        // The chosen algorithm to sort the top 3 most borrowed tools
        private static void InsertionSort(Tool[] A)
        {
            //Input: An array A[0..n - 1] of n orderable elements
            // Output: The total number of key comparisons made
            int n = A.Length;
            for (int i = 1; i <= n - 1; i++)
            {
                Tool v = A[i];
                int j = i - 1;
                while (j >= 0 && A[j].NoBorrowings.CompareTo(v.NoBorrowings) == -1)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = v;
            }
        }
    }
}

