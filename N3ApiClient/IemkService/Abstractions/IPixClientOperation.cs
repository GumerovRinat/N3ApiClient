using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.DataContracts;

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
        IOperationResult Execute(PixServiceClient clientInstance);
    }
}
