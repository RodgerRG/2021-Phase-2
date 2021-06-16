using HotChocolate;

namespace Visual_Studio_Projects.GraphQL.Students
{
    public class AddStudentInput
    {
        [GraphQLNonNullType]
        public string Name { get; set; }

        [GraphQLNonNullType]
        public string GitHub { get; set; }

        [GraphQLNonNullType]
        public string ImageURI { get; set; }
    }
}