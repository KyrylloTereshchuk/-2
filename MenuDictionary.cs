using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MenuDictionary
    {
        private readonly ICommands _Commands;
        public MenuDictionary(ICommands command)
        {
            _Commands = command;
        }


        public Dictionary<Enums.QueriesNames, Action> MenuCreate()
        {
            var menuChoices = new Dictionary<Enums.QueriesNames, Action>()
               {
                       {Enums.QueriesNames.Exit, () => _Commands.Exit()},
                       {Enums.QueriesNames.GetArticleList, () => _Commands.Command1()},
                       {Enums.QueriesNames.GetMagazinesPeriodicity, () => _Commands.Command2()},
                       {Enums.QueriesNames.GetCommentToArticle, () => _Commands.Command3()},
                       {Enums.QueriesNames.GetAuthorsByCondition, () => _Commands.Command4()},
                       {Enums.QueriesNames.GetCommentsByCondition, () => _Commands.Command5()},
                       {Enums.QueriesNames.GetCollaborations, () => _Commands.Command6()},
                       {Enums.QueriesNames.GetAuthorsByWorkplace, () => _Commands.Command7()},
                       {Enums.QueriesNames.GetLargestCirculation, () => _Commands.Command8()},
                       {Enums.QueriesNames.GetFirstArticleByCondition, () => _Commands.Command9()},
                       {Enums.QueriesNames.GetCommentsByConditionUseDelegate, () => _Commands.Command10()},
                       {Enums.QueriesNames.GetCommentsToArticle, () => _Commands.Command11()},
                       {Enums.QueriesNames.GetAuthorsFromOneOfTwoWorkplace, () => _Commands.Command12()},
                       {Enums.QueriesNames.GetMagazinesFromRange, () => _Commands.Command13()},
                       {Enums.QueriesNames.GetAuthorsWorkplace, () => _Commands.Command14()},
                       {Enums.QueriesNames.GetCommentedArticles, () => _Commands.Command15()},
                       {Enums.QueriesNames.GetNumberOfCommentsToArticle, () => _Commands.Command16()},
                       {Enums.QueriesNames.GetMagazinesArray, () => _Commands.Command17()},
                       {Enums.QueriesNames.GetCommentsByDateAndTime, () => _Commands.Command18()},
                       {Enums.QueriesNames.GetTotalArticlesSize, () => _Commands.Command19()},
                       {Enums.QueriesNames.GetMagazinesThatNeedAuthor, () => _Commands.Command20()},
                       {Enums.QueriesNames.GetMagazinesByPublications, () => _Commands.Command21()},
                       {Enums.QueriesNames.GetArticlesAndMagazinesInWhichTheyPublished, () => _Commands.Command22() },
               };
            return menuChoices;
        }
    }
}
