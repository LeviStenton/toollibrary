using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Assignment
{
    public class MemberCollection : iMemberCollection
    {
        // Binary Search Tree to store the members
        private BSTree memberCollections = new BSTree();

        // Number of members in in memberCollection
        private int number;

        // Getters of number
        public int Number { get { return number; } }

        //add a new member to this member collection, make sure there are no duplicates in the member collection
        public void add(Member aMember)
        {
            memberCollections.Insert(aMember);
            ++number;
        }

        //delete a given member from this member collection, a member can be deleted only when the member currently is not holding any tool
        public void delete(Member aMember)
        {
            memberCollections.Delete(aMember);
            --number;
        }

        //search a given member in this member collection. Return true if this memeber is in the member collection; return false otherwise.
        public bool search(Member aMember)
        {
            for(int i = 0; i < Number; ++i)
                if (memberCollections.Search(aMember))
                    return true;
            return false;
        }

        //output the memebers in this collection to an array of iMember
        public Member[] toArray()
        {            
            return memberCollections.ItemArray;
        }
    }
}
