using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.OperationDto;

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
        OperationResult Execute(EmkServiceClient clientInstance);
    }
}
