using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.SectionA
{
    internal class CandidatePriorityQueue
    {
        private MaxHeap heap; // Max Heap to store the candidates
        private int count; // Number of candidates in the queue

        // Constructor to initialize the priority queue with a given size
        public CandidatePriorityQueue(int maxSize)
        {
            heap = new MaxHeap(maxSize);
            count = 0;
        }

        public void EnqueCandidates(InterviewCandidate[] inputCandidates)
        {
            // Insert each candidate into the heap
            foreach (InterviewCandidate candidate in inputCandidates)
            {
                heap.Insert(candidate);
                count++;
            }
        }

        public InterviewCandidate DequeNextCandidate()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }

            // Remove the candidate with the highest points from the heap
            InterviewCandidate nextCandidate = heap.Remove();

            // Decrement the count
            count--;

            return nextCandidate;
        }


    }
}
