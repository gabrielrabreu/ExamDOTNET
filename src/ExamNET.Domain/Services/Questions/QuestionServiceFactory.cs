using ExamNET.Domain.Enums;
using ExamNET.Domain.Services.Questions.Mathematics;
using ExamNET.Domain.Services.Questions.Portuguese;

namespace ExamNET.Domain.Services.Questions
{
    public static class QuestionServiceFactory
    {
        public static BaseQuestionService Get(QuestionType type)
        {
            return type switch
            {
                QuestionType.MATHEMATICS_DICTATION => new MathematicsDictationQuestionService(),
                QuestionType.MATHEMATICS_PREDECESSOR_SUCCESSOR => new MathematicsPredecessorSuccessorQuestionService(),
                QuestionType.MATHEMATICS_WRITE_EXTENSE => new MathematicsWriteExtenseQuestionService(),
                QuestionType.MATHEMATICS_WRITE_NUMBER => new MathematicsWriteNumberQuestionService(),
                QuestionType.MATHEMATICS_DECOMPOSE => new MathematicsDecomposeQuestionService(),
                QuestionType.MATHEMATICS_FOUR_OPERATIONS => new MathematicsFourOperationsQuestionService(),
                QuestionType.MATHEMATICS_LOGIC => new MathematicsLogicQuestionService(),
                QuestionType.PORTUGUESE_DICTATION => new PortugueseDictationQuestionService(),
                QuestionType.PORTUGUESE_SEPARATE_SYLLABLES => new PortugueseSeparateSyllablesQuestionService(),
                QuestionType.PORTUGUESE_CONSONANT_CLUSTERS => new PortugueseConsonantClustersQuestionService(),
                QuestionType.PORTUGUESE_CREATE_PHRASES => new PortugueseCreatePhraseQuestionService(),
                QuestionType.PORTUGUESE_ANTONYMS => new PortugueseAntonymQuestionService(),
                _ => throw new ArgumentNullException(typeof(BaseQuestionService).Name)
            }; ;
        }
    }
}
