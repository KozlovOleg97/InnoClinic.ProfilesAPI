using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;

namespace InnoClinic.ProfilesAPI.Core.Services
{
    public class PatientScoringService
    {
        private readonly Dictionary<string, int> _fieldWeights;

        public PatientScoringService()
        {
            _fieldWeights = new Dictionary<string, int>()
            {
                {nameof(PatientMatchDTO.FirstName), 5 },
                {nameof(PatientMatchDTO.LastName), 5 },
                {nameof(PatientMatchDTO.MiddleName), 5 },
                {nameof(PatientMatchDTO.DateOfBirth), 3}
            };
        }

        public int CalculateMatchScore(PatientMatchDTO patientMatchDTO)
        {
            int score = 0;

            foreach (var field in _fieldWeights)
            {
                var propertyValue = typeof(PatientMatchDTO).GetProperty(field.Key)?.GetValue(patientMatchDTO);

                if (propertyValue != null)
                {
                    score += field.Value;
                }
            }

            return score;
        }
    }
}
