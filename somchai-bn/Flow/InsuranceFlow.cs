using somchai_bn.BusinessFlow;
using somchai_bn.Model;
using System.Transactions;

namespace somchai_bn.Flow
{
    public class InsuranceFlow
    {
        private BaseRepository repository;
        public InsuranceFlow()
        {
            repository = new BaseRepository();
        }
        public GetCountryResponse GetCountryByAirport(GetCountryRequest request)
        {
            List<CountryByAirportEntity> getCountryByAirport = repository.GetAllEntity<CountryByAirportEntity>();
            CountryByAirportEntity originalCountry = getCountryByAirport.First(x => x.id == request.originalAirport);
            CountryByAirportEntity destinationCountry = getCountryByAirport.First(x => x.id == request.destinationAirport);
            GetCountryResponse response = new()
            {
                originalCountry = originalCountry.country,
                originalKey = originalCountry.keyid,
                destinationCountry = destinationCountry.country,
                destinationKey = destinationCountry.keyid
            };
            return response;
        }
        public GetTransactionResponse GetTransaction(string id)
        {
            TransactionEntity getTransaction = repository.GetEntity<TransactionEntity>(id);
            List<PersonEntity> getPerson = repository.GetAllEntity<PersonEntity>();

            GetTransactionResponse response = new()
            {
                transaction = getTransaction.id,
                person = getPerson.Where(x => x.transactionId == getTransaction.id).ToList()
            };
            return response;
        }
        public PostTransactionResponse PostTransaction(PostTransactionRequest request)
        {
            TransactionEntity transaction = new TransactionEntity()
            {
                id = Guid.NewGuid().ToString("N"),
                amount = request.amount
            };
            repository.SaveEntity(transaction);

            foreach (PersonEntity person in request.person)
            {
                person.transactionId = transaction.id;
                PostPerson(person);
            }

            PostTransactionResponse response = new()
            {
                transaction = transaction.id
            };
            return response;
        }
        public PersonEntity PostPerson(PersonEntity request)
        {
            repository.SaveEntity(request);
            return request;
        }
        public PersonEntity GetPerson(long id)
        {
            PersonEntity response = repository.GetEntity<PersonEntity>(id);
            return response;
        }
    }
}
