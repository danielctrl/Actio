using Actio.Common.Commands;
using RawRabbit;
using RawRabbit.Instantiation;
using RawRabbit.Pipe;
using System.Reflection;
using System.Threading.Tasks;

namespace Actio.Common.RabbitMq
{
    public static class Extensions
    {
        public static Task WithCommandHandlerAsync<TCommand>(this IBusClient bus, ICommandHandler<TCommand> handler)
            where TCommand : ICommand
        {
            var client = RawRabbitFactory.CreateSingleton();

            return await client.SubscribeAsync<TCommand>(
                msg => handler.HandleAsync(msg),
                ctx => ctx.UseConsumerConfiguration(cfg => cfg.FromDeclaredQueue(q => q.WithName()))
            );
        }

        private static string GetQueueName<T>() => $"{Assembly.GetEntryAssembly().GetName()}/{typeof(T).Name}";
    }
}
