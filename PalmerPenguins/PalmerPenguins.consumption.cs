﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace PalmerPenguins
{
    public partial class PalmerPenguins
    {
        /// <summary>
        /// model input class for PalmerPenguins.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"species")]
            public string Species { get; set; }

            [ColumnName(@"island")]
            public string Island { get; set; }

            [ColumnName(@"bill_length_mm")]
            public float Bill_length_mm { get; set; }

            [ColumnName(@"bill_depth_mm")]
            public float Bill_depth_mm { get; set; }

            [ColumnName(@"flipper_length_mm")]
            public float Flipper_length_mm { get; set; }

            [ColumnName(@"body_mass_g")]
            public float Body_mass_g { get; set; }

            [ColumnName(@"sex")]
            public string Sex { get; set; }

            [ColumnName(@"year")]
            public float Year { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for PalmerPenguins.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"species")]
            public uint Species { get; set; }

            [ColumnName(@"island")]
            public float[] Island { get; set; }

            [ColumnName(@"bill_length_mm")]
            public float Bill_length_mm { get; set; }

            [ColumnName(@"bill_depth_mm")]
            public float Bill_depth_mm { get; set; }

            [ColumnName(@"flipper_length_mm")]
            public float Flipper_length_mm { get; set; }

            [ColumnName(@"body_mass_g")]
            public float Body_mass_g { get; set; }

            [ColumnName(@"sex")]
            public float[] Sex { get; set; }

            [ColumnName(@"year")]
            public float Year { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("PalmerPenguins.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
