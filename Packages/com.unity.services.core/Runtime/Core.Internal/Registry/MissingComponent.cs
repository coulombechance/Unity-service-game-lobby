namespace Unity.Services.Core
{
    /// <summary>
    /// Placeholder for required <see cref="IServiceComponent"/> registered into a <see cref="CoreRegistry"/>.
    /// </summary>
    class MissingComponent : IServiceComponent
    {
        public static MissingComponent Instance { get; }
            = new MissingComponent();

        MissingComponent() {}
    }
}
