using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.SectionA
{
    class InterviewCandidate
    {
        public string CandidateName { get; set; }        //Stores full Name of the Candidate e.g. John Smith

        //Stores a list of certifications for the candidate where the 
        //Key is the name of the certification e.g. BSc Software Development
        //Value is a number of points awarded to the certification on scale of 1 to 10 e.g. 8 
        public List<KeyValuePair<string, int>> CertificationList { get; set; }

        public int yearsOfExperience { get; set; }      //Stores the number of years of relevant experience for the candidate

        //Overloaded contructor to instanciate an object for the Interview Candidate with Data
        public InterviewCandidate(string candidateName, List<KeyValuePair<string, int>> certificationList, int yearsOfExperience)
        {
            CandidateName = candidateName;
            CertificationList = certificationList;
            this.yearsOfExperience = yearsOfExperience;
        }

        /// <summary>
        /// Calculates the total number of points to be awarded to a candidate based on certifications and years of experience
        /// </summary>
        /// <returns>int total number of points obtained by a candidate</returns>
        public int CalculateCandidatePoints()
        {
            int points = 0;
            //Add the points awarded to each certification together
            foreach (KeyValuePair<string, int> certification in CertificationList)
            {
                points += certification.Value;
            }
            //Add an additional 2points for every year of experience held by the candidate
            points += yearsOfExperience * 2;
            return points;
        }


        public static InterviewCandidate[] GenerateRandomCandidates(int numberOfCandidates)
        {
            //Create an array to hold the required number of interview candidates 
            InterviewCandidate[] candidates = new InterviewCandidate[numberOfCandidates];

            Random dataRandomizer = new Random();

            //For each required candidate
            for (int c = 0; c < numberOfCandidates; c++)
            {
                //Generate random string as the candidate name
                string fullName = "Candidate Number " + dataRandomizer.Next();

                //Generate a random number as the candidate's years of experience
                int yearsOfExperience = dataRandomizer.Next(0, 45);

                //Generate a random set of qualifications for the candidate
                string[] possibleQualifications = {"O Level Certificate", "A Level certificate", "BSc. Degree", "MSc. Degree", "Doctoral Degree",
                                                "Associate Industry Certification Associate", "Professional Industry Certification"};

                //Determine how many qualifications the candidate will have
                int numberOfQualifications = dataRandomizer.Next(0, 5);

                //Generate the required number of random qualifications and save them in a list
                List<KeyValuePair<string, int>> qualifications = new List<KeyValuePair<string, int>>();
                for (int i = 0; i < numberOfQualifications; i++)
                {
                    int randomQualificationIndex = dataRandomizer.Next(0, 6);
                    int randomQualificationValue = dataRandomizer.Next(1, 10);
                    qualifications.Add(new KeyValuePair<string, int>(possibleQualifications[randomQualificationIndex], randomQualificationValue));
                }

                //Generate a candidate object based on the random data generated
                InterviewCandidate candidate = new InterviewCandidate(fullName, qualifications, yearsOfExperience);

                //Add the candidate to the array to be returned
                candidates[c] = candidate;
            }

            //return the array of candidates
            return candidates;
        }

    }
}
