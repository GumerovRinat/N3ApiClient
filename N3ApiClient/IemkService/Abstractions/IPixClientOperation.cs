using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.OperationDto;

namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Операция клиента для сервиса обемена дынными пациентов
    /// </summary>
    public interface IPixClientOperation
    {
        /// <summary>
        /// Выполнение операции
        /// </summary>
        /// <param name="clientInstance">Экземпляр клиента</param>
        /// <returns>Результат выполнения</returns>
        OperationResult Execute(PixServiceClient clientInstance);
    }
}
