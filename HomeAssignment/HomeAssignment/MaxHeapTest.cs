using System;

namespace HomeAssignment
{
    class MaxHeapTest
    {
        public static void test()
        {
            //Create a MaxHeap to store  candidates based on points obtained - highest amount of points first
            MaxHeap candidateHeap = new MaxHeap(15);


            //Generate an array of 15 random candidates with random qualifications
            InterviewCandidate[] randomCandidateSet = InterviewCandidate.GenerateRandomCandidates(15);

            //Add Each candidate to the MaxHeap
            foreach (InterviewCandidate candidate in randomCandidateSet)
            {
                candidateHeap.Insert(candidate);
            }

            //Empty the heap, and check thaat candidates are outputted with th eones having the most points first
            for (int i = 0; i < 15; i++)
            {
                InterviewCandidate c = candidateHeap.Remove();
                Console.Write("\n\nName : {0}\t Experience : {1} years \t Points {2}\n",
                                c.CandidateName, c.yearsOfExperience, c.CalculateCandidatePoints());
            }
        }
    }
}
