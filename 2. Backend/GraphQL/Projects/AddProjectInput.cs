using HotChocolate;

namespace Visual_Studio_Projects.GraphQL.Projects
{
    public class AddProjectInput
    {
        [GraphQLNonNullType]
        public string Name { get; set; }

        [GraphQLNonNullType]
        public string Description { get; set; }

        [GraphQLNonNullType]
        public string Link { get; set; }

        [GraphQLNonNullType]
        public string Year { get; set; }

        [GraphQLNonNullType]
        public string StudentId { get; set; }
    }

}