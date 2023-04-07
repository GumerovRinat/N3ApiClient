using N3ApiClient.Base.Abstractions;

namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Основной интерфейс клиента ИЭМК
    /// </summary>
    public interface IEmkClient
    {
        /// <summary>
        /// Выполнение операции клиентом
        /// </summary>
        /// <param name="operation">Операция</param>
        /// <returns>Результат выполнения</returns>
        IOperationResult ExecuteOperation(IEmkClientOperation operation);
    }
}
