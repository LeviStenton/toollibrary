using Assignment;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CAB301_Assignment
{
    public class Member : iMember
    {
        // Borrowed tools by the member
        private ToolCollection tools = new ToolCollection();
        // Private fields to be accessed by the getters and setters
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string pin;

        // Get and set the first name of this member
        public string FirstName  
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Get and set the last name of this member
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Get and set the contact number of this member
        public string ContactNumber 
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        // Get and set the password of this member
        public string PIN 
        {
            get { return pin; }
            set { pin = value; }
        }

        // Get a list of tools that this member is currently holding
        public Tool[] Tools { 
            get { return tools.toArray(); } 
        }

        // Add a given tool to the list of tools that this member is currently holding
        public void addTool(Tool aTool) 
        {
            tools.add(aTool);
        }

        // Delete a given tool from the list of tools that this member is currently holding
        public void deleteTool(Tool aTool) 
        {
            tools.delete(aTool);
        }

        // Return a string containing the first name, lastname, and contact phone number of this memeber
        public override string ToString() 
        {
            return FirstName + " " + LastName + ", " + ContactNumber;
        }

        // Method to compare members by their last and first names
        public int CompareTo([AllowNull] Member other)
        {
            Member member = other;
            int outcome = this.LastName.CompareTo(member.LastName);
            if (outcome == 0)
                return this.FirstName.CompareTo(member.FirstName);
            else
                return outcome;
        }
    }
}
