using N3ApiClient.IemkService.Exceptions;

namespace N3ApiClient.IemkService.Abstractions
{
    /// <summary>
    /// Результат выполнения операции
    /// </summary>
    public interface IOperationResult
    {
        /// <summary>
        /// Возвращает признак успешности выполнения
        /// </summary>
        /// <returns>Признак успешности</returns>
        bool IsSuccess();

        /// <summary>
        /// Задать успешность выполнения
        /// </summary>
        /// <param name="success">Флаг успеха выполнения</param>
        IOperationResult SetSuccess(bool success);

        /// <summary>
        /// Получить сведения об ошибке при выполнении операции
        /// </summary>
        /// <returns>Сведения об ошибке</returns>
        NetrikaClientException GetException();

        /// <summary>
        /// Задать ошбку при выполнении операции
        /// </summary>
        /// <param name="exception">Исключение</param>
        IOperationResult SetException(object exception);

        /// <summary>
        /// Задать ошбку при выполнении операции
        /// </summary>
        /// <param name="exception">Исключение</param>
        IOperationResult SetExceptionMessage(string message);

        /// <summary>
        /// Возвращает объект полученный в результате выполнения операции
        /// </summary>
        /// <returns>Объек результата выполнения операции</returns>
        T GetResult<T>();

        /// <summary>
        /// Задать результат выполнения операции
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        IOperationResult SetResult(object result);
    }
}
