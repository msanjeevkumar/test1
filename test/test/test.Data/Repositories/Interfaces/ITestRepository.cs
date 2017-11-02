using System;
using System.Threading.Tasks;
using test.Data.Entities;

namespace test.Data.Repositories.Interfaces
{
	public interface ITestRepository
	{
		Task SaveItem(TestEntity testEntity);

		Task<TestEntity> GetTestEntity(string key);

		Task UpdateItem(TestEntity testEntity);

		Task DeleteItem(TestEntity testEntity);
	}
}
