namespace Discord
{
    /// <summary>
    ///     A metadata containing reaction information.
    /// </summary>
    public struct ReactionMetadata
    {
        /// <summary>
        ///     Gets the number of reactions.
        /// </summary>
        /// <returns>
        ///     An <see cref="int"/> representing the number of this reactions that has been added to this message.
        /// </returns>
        public int ReactionCount { get; internal set; }

        /// <summary>
        ///     Gets a value that indicates whether the current user has reacted to this.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the user has reacted to the message; otherwise <see langword="false" />.
        /// </returns>
        public bool IsMe { get; internal set; }
    }
}
