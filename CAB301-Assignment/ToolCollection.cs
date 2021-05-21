using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Assignment
{
    public class ToolCollection : iToolCollection
    {
        // Arrays of tools in this collection
        private Tool[] toolCollection = new Tool[30];

        // Number of tools in the array
        private int number;

        // Get the number of the types of tools in the community library
        public int Number 
        { get { return number; } }

        // Add a given tool to this tool collection
        public void add(Tool aTool) 
        {
            for(int i = 0; i < toolCollection.Length; ++i)
                if (toolCollection[i] == null)
                {
                    toolCollection[i] = aTool;
                    break;
                }
            ++number;
        }

        // Delete a given tool from this tool collection
        public void delete(Tool aTool) 
        {
            for (int i = 0; i < toolCollection.Length; ++i)
                if (toolCollection[i] == aTool)
                {
                    toolCollection[i] = null;
                    break;
                }
            --number;
        }

        // Search a given tool in this tool collection. Return true if this tool is in the tool collection; return false otherwise
        public bool search(Tool aTool) 
        {
            for(int i = 0; i < Number; ++i)
                if (toolCollection[i].Equals(aTool))
                    return true;
            return false;
        }

        // Output the tools in this tool collection to an array of iTool
        public Tool[] toArray() 
        {
            Tool[] rArray = new Tool[Number];
            int tIdx = 0;
            for(int i = 0; i < toolCollection.Length; ++i)
                if (toolCollection[i] != null)
                {
                    rArray[tIdx] = toolCollection[i];
                    ++tIdx;
                }
            return rArray;
        }
    }
}
