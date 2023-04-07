using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.DataContracts;

namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Операция сервиса ИЭМК
    /// </summary>
    public interface IEmkClientOperation
    {
        /// <summary>
        /// Выполнение операции
        /// </summary>
        /// <param name="clientInstance">Инстанс клиента, для сервиса ИЭМК</param>
        /// <returns>Результат выполнения операции</returns>
        IOperationResult Execute(EmkServiceClient clientInstance);
    }
}
