using System;
using System.Reactive.Linq;

namespace NetDaemon.HassModel.Entities
{
    /// <summary>
    /// Provides Extension methods for Entities
    /// </summary>
    public static class EntityExtensions
    {
        public static IDisposable WhenTurnsOn<T, TAttributes>(this Entity<T, EntityState<TAttributes>, TAttributes> entity,
            Action<StateChange<T, EntityState<TAttributes>>> observer)
            where TAttributes : class
            where T : Entity<T, EntityState<TAttributes>, TAttributes>
            => entity.StateChanges().Where(c => (c.Old?.IsOff() ?? false) && (c.New?.IsOn() ?? false)).Subscribe(observer);

        public static IDisposable WhenTurnsOff<T, TAttributes>(this Entity<T, EntityState<TAttributes>, TAttributes> entity,
            Action<StateChange<T, EntityState<TAttributes>>> observer)
            where TAttributes : class
            where T : Entity<T, EntityState<TAttributes>, TAttributes>
            => entity.StateChanges().Where(c => (c.Old?.IsOn() ?? false) && (c.New?.IsOff() ?? false)).Subscribe(observer);
    }



}