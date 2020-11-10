namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers
{
    public interface IStandardizerLookupTable
    {
        #region VERBAL TESTS

        short GetInformationStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetInformationDescriptor();

        short GetSimilaritiesStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetSimilaritiesDescriptor();

        short GetArithmeticStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetArithmeticDescriptor();

        short GetVocabularyStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetVocabularyDescriptor();

        short GetComprehensionStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetComprehensionDescriptor();

        short GetDigitMemoryStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetDigitMemoryDescriptor();

        #endregion

        #region REALIZATION TESTS

        short GetImageCompletionStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetImageCompletionDescriptor();

        short GetCodeStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetCodeDescriptor();

        short GetImageDispositionStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetImageDispositionDescriptor();

        short GetCubesStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetCubesDescriptor();

        short GetObjectCompositionStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetObjectCompositionDescriptor();

        short GetSymbolSearchStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetSymbolSearchDescriptor();

        short GetLabyrinthStandardizedResult(short rawResult);

        internal TestDescriptorPerAge GetLabyrinthDescriptor();

        #endregion
    }
}
