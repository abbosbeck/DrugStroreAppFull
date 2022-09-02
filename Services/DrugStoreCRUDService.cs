using DataAccess;
using DataAccess.Entities;
using DrugStroreAppFull.Models;

namespace DrugStroreAppFull.Services
{
    public class DrugStoreCRUDService : IGenericCRUDService<DrugStoreModel>
    {
        private readonly IGenericRepository<DrugStore> _drugStoresRepository;
        public DrugStoreCRUDService(IGenericRepository<DrugStore> drugStoresRepository)
        {
            _drugStoresRepository = drugStoresRepository;
        }
        public async Task<DrugStoreModel> Create(DrugStoreModel model)
        {
            var drugStore = new DrugStore
            {
                Id = model.Id,
                DrugName = model.DrugName,
                Description = model.Description,
                Location = model.Location,
                Capacity = model.Capacity
            };
            var createdStore = await _drugStoresRepository.Create(drugStore);
            var result = new DrugStoreModel
            {
                Id = createdStore.Id,
                DrugName = createdStore.DrugName,
                Description = createdStore.Description,
                Location = createdStore.Location,
                Capacity = createdStore.Capacity
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _drugStoresRepository.Delete(id);
        }

        public async Task<IEnumerable<DrugStoreModel>> GetAll()
        {
            var result = new List<DrugStoreModel>();
            var stores = await _drugStoresRepository.GetAll();
            foreach (var store in stores)
            {
                var model = new DrugStoreModel
                {
                    Id = store.Id,
                    DrugName = store.DrugName,
                    Description = store.Description,
                    Location = store.Location,
                    Capacity = store.Capacity
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<DrugStoreModel> GetById(int id)
        {
            var store = await _drugStoresRepository.GetById(id);
            var result = new DrugStoreModel
            {
                Id = store.Id,
                DrugName = store.DrugName,
                Description = store.Description,
                Location = store.Location,
                Capacity = store.Capacity
            };
            return result;
        }

        public async Task<DrugStoreModel> Update(int id, DrugStoreModel model)
        {
            var store = new DrugStore
            {
                Id = model.Id,
                DrugName = model.DrugName,
                Description = model.Description,
                Location = model.Location,
                Capacity = model.Capacity
            };
            var updateStore = await _drugStoresRepository.Update(id, store);
            var result = new DrugStoreModel
            {
                Id = updateStore.Id,
                DrugName = updateStore.DrugName,
                Description = updateStore.Description,
                Location = updateStore.Location,
                Capacity = updateStore.Capacity
            };
            return result;
        }
    }
}
