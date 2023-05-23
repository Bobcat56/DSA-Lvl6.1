using System;

namespace HomeAssignment.SectionA
{
    class MaxHeap
    {
        // Array to store the Interview Candidates
        private InterviewCandidate[] heap;
        // Current number of elements in the heap
        private int size;

        // Constructor to initialize the heap with a given size
        public MaxHeap(int maxSize)
        {
            heap = new InterviewCandidate[maxSize];
            size = 0;
        }

        public void Insert(InterviewCandidate candidate)
        {

            // Insert candidate at the next free location in the heap
            heap[size] = candidate;

            // Perform heapify-up to maintain the heap property
            HeapifyUp(size);

            // Increment the size
            size++;
        }

        private void HeapifyUp(int index)
        {
            // Calculate the parent index
            int parentIndex = (index - 1) / 2;

            // Compare the candidates points with its parents points
            // If the candidate has more points, swap them and continue
            if (index > 0 && heap[index].CalculateCandidatePoints() > heap[parentIndex].CalculateCandidatePoints())
            {
                Swap(index, parentIndex);
                HeapifyUp(parentIndex);
            }
        }

        public InterviewCandidate Remove()
        {
            if (size == 0)
            {

                throw new InvalidOperationException("Heap is empty");
            }

            // Store the candidate with the highest points at the root
            InterviewCandidate maxCandidate = heap[0];

            // Replace the root with last candidate in the heap
            heap[0] = heap[size - 1];

            // Decrement the size
            size--;

            // Perform heapify-down to maintain heap
            HeapifyDown(0);

            return maxCandidate;
        }

        private void HeapifyDown(int index)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int largestIndex = index;

            // Compare the candidate at the current index with its left and right child
            // Find the index of the candidate with the highest points among them
            if (leftChildIndex < size && heap[leftChildIndex].CalculateCandidatePoints() > heap[largestIndex].CalculateCandidatePoints())
            {
                largestIndex = leftChildIndex;
            }

            if (rightChildIndex < size && heap[rightChildIndex].CalculateCandidatePoints() > heap[largestIndex].CalculateCandidatePoints())
            {
                largestIndex = rightChildIndex;
            }

            // If the candidate at the current index is not the largest, swap it with the largest candidate
            // and continue heapify-down from the largest index
            if (largestIndex != index)
            {
                Swap(index, largestIndex);
                HeapifyDown(largestIndex);
            }
        }

        public InterviewCandidate Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty");

            return heap[0];
        }

        private void Swap(int index1, int index2)
        {
            InterviewCandidate temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
}
