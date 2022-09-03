using DataAccess;
using DataAccess.Entities;
using DrugStroreAppFull.Models;

namespace DrugStroreAppFull.Services
{
    public class MedicineCRUDService : IGenericCRUDService<MedicineModel>
    {
        private readonly IGenericRepository<Medicine> _medicineRepository;
        public MedicineCRUDService(IGenericRepository<Medicine> medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        public async Task<MedicineModel> Create(MedicineModel model)
        {
            var medicine = new Medicine
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ProductionDate = model.ProductionDate,
                Expiration = model.Expiration
            };
            var createdMedicine = await _medicineRepository.Create(medicine);
            var result = new MedicineModel
            {
                Id = createdMedicine.Id,
                Name = createdMedicine.Name,
                Description = createdMedicine.Description,
                ProductionDate = createdMedicine.ProductionDate,
                Expiration = createdMedicine.Expiration
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _medicineRepository.Delete(id);
        }

        public async Task<IEnumerable<MedicineModel>> GetAll()
        {
            var result = new List<MedicineModel>();
            var medicines = await _medicineRepository.GetAll();
            foreach (var medicine in medicines)
            {
                var model = new MedicineModel
                {
                    Id = medicine.Id,
                    Name = medicine.Name,
                    Description = medicine.Description,
                    ProductionDate = medicine.ProductionDate,
                    Expiration = medicine.Expiration
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<MedicineModel> GetById(int id)
        {
            var medicine = await _medicineRepository.GetById(id);
            var result = new MedicineModel
            {
                Id = medicine.Id,
                Name = medicine.Name,
                Description = medicine.Description,
                ProductionDate = medicine.ProductionDate,
                Expiration = medicine.Expiration
            };
            return result;
        }

        public async Task<MedicineModel> Update(int id, MedicineModel model)
        {
            var medicine = new Medicine
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ProductionDate = model.ProductionDate,
                Expiration = model.Expiration
            };
            var updatedMedicine = await _medicineRepository.Update(id, medicine);
            var result = new MedicineModel
            {
                Id = updatedMedicine.Id,
                Name = updatedMedicine.Name,
                Description = updatedMedicine.Description,
                ProductionDate = updatedMedicine.ProductionDate,
                Expiration = updatedMedicine.Expiration
            };
            return result;
        }
    }
}
