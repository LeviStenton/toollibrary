using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Assignment
{
    public class Tool : iTool
    {
        // Members that are borrowing this tool
        private MemberCollection members = new MemberCollection();
        // Private fields to be accessed by their getters and setters
        private string name = "Null";
        private int quantity = 1;
        private int availableQuantity = 1;
        private int noBorrowings = 0;

        // Get and set the name of this tool
        public string Name { get { return name; } set { name = value; } }
        // Get and set the quantity of this tool
        public int Quantity { get { return quantity; } set { int borrowedNum = quantity - availableQuantity; quantity = value; availableQuantity = quantity - borrowedNum; } }
        // Get and set the quantity of this tool currently available to lend
        public int AvailableQuantity { get { return availableQuantity; } set {availableQuantity = value; } }
        // Get and set the number of times that this tool has been borrowed
        public int NoBorrowings { get { return noBorrowings; } set { noBorrowings = value; } }
        // Get all the members who are currently holding this tool
        public MemberCollection GetBorrowers { get { return members; } } //get all the members who are currently holding this tool

        // Add a member to the borrower list
        public void addBorrower(Member aMember) 
        {
            members.add(aMember);
        }

        // Delete a member from the borrower list
        public void deleteBorrower(Member aMember) 
        {
            members.delete(aMember);
        }

        // Return a string containning the name and the available quantity quantity this tool
        public override string ToString()  
        { 
            return "Name: " + Name + ", Available Quantity: " + AvailableQuantity;
        }
        
    }
}
