namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Фабрика клиентов для сервиса обмена данными пациентов
    /// </summary>
    public abstract class PixClientFactory
    {
        /// <summary>
        /// Создание инстанса клиента
        /// </summary>
        /// <returns></returns>
        public abstract IPixClient CreateInstance();

        /// <summary>
        /// Выполнение операции
        /// </summary>
        /// <param name="operation">Операция</param>
        /// <returns>Результат выполнения</returns>
        public IOperationResult ExecuteOperation(IPixClientOperation operation)
        {
            var client = CreateInstance();
            return client.ExecuteOperation(operation);
        }
    }
}
