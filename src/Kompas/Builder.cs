using Kompas6API5;
using Kompas6Constants3D;
using Core;

namespace Kompas
{
    /// <summary>
    /// Сборщик модели
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Построить модель
        /// </summary>
        public void Build(KompasObject kompasObject, LinkPinParameter parameters)
        {
            ksDocument3D document3D = 
                kompasObject.Document3D();
            document3D.Create();
            ksPart part = 
                document3D.GetPart((int)Part_Type.pTop_Part);
            CreateHead(part, parameters);
            CreateRod(part, parameters);
            CreateHole(part, parameters);
            ChamferDef(part, 2, 
                parameters.HeadChamferDepth, parameters.HeadAngleDepth);
            ChamferDef(part, 3, 
                parameters.RodChamferDepth, parameters.RodAngleDepth);
            if (parameters.Cutting)
            {
                CreateCutting(part, parameters);
            }
        }

        /// <summary>
        /// Выдавливание объекта
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="sketch">эскиз</param>
        /// <param name="height">высота фигуры</param>
        private void BossExtrusion(ksPart part, ksEntity sketch, double height)
        {
            ksEntity extrude = 
                part.NewEntity((int) Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrudeDefinition = 
                extrude.GetDefinition();
            extrudeDefinition.directionType = 
                (int) Direction_Type.dtNormal;
            extrudeDefinition.SetSketch(sketch);
            ksExtrusionParam extrudeParam = 
                extrudeDefinition.ExtrusionParam();
            extrudeParam.depthNormal = height;
            extrude.Create();
        }

        /// <summary>
        /// Построение фасок 
        /// </summary>
        /// <param name="part">часть</param>
        /// <param name="index">индекс грани</param>
        /// <param name="depth">длина</param>
        /// <param name="angle">угол</param>
        private void ChamferDef(ksPart part, int index, double depth, double angle)
        {
            ksEntityCollection collection = 
                (ksEntityCollection)part.EntityCollection((short)Obj3dType.o3d_face);
            ksEntity entityChamfer = 
                (ksEntity)part.NewEntity((short)Obj3dType.o3d_chamfer);
            ksChamferDefinition chamferDef = 
                (ksChamferDefinition)entityChamfer.GetDefinition();
            chamferDef.tangent = false;
            chamferDef.SetChamferParam(false, 
                depth, depth * angle / 45);
            ksEntityCollection arr = 
                (ksEntityCollection)chamferDef.array();
            arr.Add(collection.GetByIndex(index));
            entityChamfer.Create();
        }

        /// <summary>
        /// Выдавливание выреза
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="sketch">эскиз</param>
        /// <param name="height">высота фигуры</param>
        private void CutExtrusion(ksPart part, ksEntity sketch, double height)
        {
            ksEntity cutExtrusion =
                (ksEntity)part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition extrusionDefinition =
                cutExtrusion.GetDefinition();
            ksExtrusionParam extrusionParam =
                (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
            extrusionDefinition.SetSketch(sketch);
            extrusionParam.direction = 
                (short)Direction_Type.dtNormal;
            extrusionParam.typeNormal = 
                (short)End_Type.etBlind;
            extrusionParam.depthNormal = height;
            cutExtrusion.Create();
        }

        /// <summary>
        /// Создать стержень
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="detailParameters">параметры детали</param>
        private void CreateRod(ksPart part, LinkPinParameter detailParameters)
        {
            ksEntity plane = 
                part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
            ksEntity sketch = 
                part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = 
                sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2DRod = 
                sketchDefinition.BeginEdit();
            document2DRod.ksCircle(0, 0, 
                detailParameters.RodRadius, 1);
            sketchDefinition.EndEdit();

            BossExtrusion(part, sketch, 
                detailParameters.RodLength);
        }

        /// <summary>
        /// Создать отверстие
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="detailParameters">параметры детали</param>
        private void CreateHole(ksPart part, LinkPinParameter detailParameters)
        {
            ksEntity plane = 
                part.GetDefaultEntity((int)Obj3dType.o3d_planeXOZ);
            ksEntity sketch = 
                part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = 
                sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2DRod = 
                sketchDefinition.BeginEdit();
            document2DRod.ksCircle(0, 
                detailParameters.HoleDistance - detailParameters.RodLength, 
                detailParameters.HoleRadius, 1);
            sketchDefinition.EndEdit();
            CutExtrusion(part, sketch, 
                detailParameters.RodRadius);
            CutExtrusion(part, sketch, 
                -detailParameters.RodRadius);
        }

        /// <summary>
        /// Создать шляпку
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="detailParameters">параметры детали</param>
        private void CreateHead(ksPart part, LinkPinParameter detailParameters)
        {
            ksEntity plane = 
                part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
            ksEntity sketch = 
                part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = 
                sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2D = 
                sketchDefinition.BeginEdit();
            document2D.ksCircle(0, 0, 
                detailParameters.HeadRadius, 1);
            sketchDefinition.EndEdit();
            BossExtrusion(part, sketch, 
                -detailParameters.HeadLength);
        }

        /// <summary>
        /// Выдавливание выреза под флажок
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="parameters">параметры детали</param>
        private void CreateCutting(ksPart part, LinkPinParameter parameters)
        {
            ksEntity plane =
                part.GetDefaultEntity((int)Obj3dType.o3d_planeYOZ);
            ksEntity sketch =
                part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition =
                sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2DRod =
                sketchDefinition.BeginEdit();
            var y1 = - parameters.RodLength;
            var y2 = - (parameters.RodLength - parameters.HoleDistance * 2);
            var z1 = parameters.RodRadius / 3;
            var z2 = -z1;
            document2DRod.ksLineSeg(y1, z1, y1, z2, 1);
            document2DRod.ksLineSeg(y1, z1, y2, z1, 1);
            document2DRod.ksLineSeg(y1, z2, y2, z2, 1);
            document2DRod.ksLineSeg(y2, z1, y2, z2, 1);
            sketchDefinition.EndEdit();
            CutExtrusion(part, sketch,
                parameters.RodRadius);
            CutExtrusion(part, sketch,
                -parameters.RodRadius);
        }
    }
}
