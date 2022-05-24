using FitnessClub.Infrastructure;

namespace FitnessClub.Infrastructure
{
    public interface IDbInitializer
    {
        void Initialize(FitnessClubContext context);
    }
}
