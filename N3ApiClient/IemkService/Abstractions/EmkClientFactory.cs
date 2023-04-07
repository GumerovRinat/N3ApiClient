using N3ApiClient.Base.Abstractions;

namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Фабрика сервиса ИЭМК
    /// </summary>
    public abstract class EmkClientFactory
    {
        /// <summary>
        /// Сознание инстанса клиента
        /// </summary>
        /// <returns>Инстанс клиента ИЭМК</returns>
        public abstract IEmkClient CreateInstance();

        /// <summary>
        /// Выполнение операции сервиса
        /// </summary>
        /// <param name="operation">Операция сервиса</param>
        /// <returns>Результат выполения операции</returns>
        public IOperationResult ExecuteOperation(IEmkClientOperation operation)
        {
            var client = CreateInstance();
            return client.ExecuteOperation(operation);
        }
    }
}
