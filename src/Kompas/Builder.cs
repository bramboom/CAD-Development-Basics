using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompas6API5;
using Kompas6Constants3D;
using Core;

namespace Kompas
{
    public class Builder
    {
        /// <summary>
        /// Построить модель
        /// </summary>
        public void Build(KompasObject kompasObject, LinkPinParameter parameters)
        {
            ksDocument3D document3D = kompasObject.Document3D();
            document3D.Create();
            ksPart part = document3D.GetPart((int)Part_Type.pTop_Part);
            CreateHead(part, parameters);
            CreateRod(part, parameters);
            CreateHole(part, parameters);
            ChampherDef(part, 2, parameters.HeadChamferDepth, parameters.HeadAngleDepth);
            ChampherDef(part, 3, parameters.RodChamferDepth, parameters.RodAngleDepth);
        }

        /// <summary>
        /// Выдавливание объекта
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="sketch">эскиз</param>
        /// <param name="height">высота фигуры</param>
        public void BossExtrusion(ksPart part, ksEntity sketch, double height)
        {
            ksEntity extrude = part.NewEntity((int) Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrudeDefinition = extrude.GetDefinition();
            extrudeDefinition.directionType = (int) Direction_Type.dtNormal;
            extrudeDefinition.SetSketch(sketch);
            ksExtrusionParam extrudeParam = extrudeDefinition.ExtrusionParam();
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
        public void ChampherDef(ksPart part, int index, double depth, double angle)
        {
            ksEntityCollection collection = (ksEntityCollection)part.EntityCollection((short)Obj3dType.o3d_face);
            ksEntity entityChamfer = (ksEntity)part.NewEntity((short)Obj3dType.o3d_chamfer);
            ksChamferDefinition ChamferDef = (ksChamferDefinition)entityChamfer.GetDefinition();
            ChamferDef.tangent = false;
            ChamferDef.SetChamferParam(false, depth, depth * angle / 45);
            ksEntityCollection arr = (ksEntityCollection)ChamferDef.array();
            arr.Add(collection.GetByIndex(index));
            entityChamfer.Create();
        }

        /// <summary>
        /// Выдавливание объекта
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="sketch">эскиз</param>
        /// <param name="height">высота фигуры</param>
        public void CutExtrusion(ksPart part, ksEntity sketch, double height)
        {
            ksEntity cutExtrusion =
                (ksEntity)part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition extrusionDefinition =
                cutExtrusion.GetDefinition();
            ksExtrusionParam extrusionParam =
                (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
            extrusionDefinition.SetSketch(sketch);
            extrusionParam.direction = (short)Direction_Type.dtNormal;
            extrusionParam.typeNormal = (short)End_Type.etBlind;
            extrusionParam.depthNormal = height;
            cutExtrusion.Create();
        }

        /// <summary>
        /// Создать стержень
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="_detailParameters">параметры детали</param>
        private void CreateRod(ksPart part, LinkPinParameter _detailParameters)
        {
            ksEntity plane = part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
            ksEntity sketch = part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2DRod = sketchDefinition.BeginEdit();
            document2DRod.ksCircle(0, 0, _detailParameters.RodRadius, 1);
            sketchDefinition.EndEdit();

            BossExtrusion(part, sketch, _detailParameters.RodLength);
        }

        /// <summary>
        /// Создать отверстие
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="_detailParameters">параметры детали</param>
        private void CreateHole(ksPart part, LinkPinParameter _detailParameters)
        {
            ksEntity plane = part.GetDefaultEntity((int)Obj3dType.o3d_planeXOZ);
            ksEntity sketch = part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2DRod = sketchDefinition.BeginEdit();
            document2DRod.ksCircle(0, _detailParameters.HoleDistance - _detailParameters.RodLength, _detailParameters.HoleRadius, 1);
            sketchDefinition.EndEdit();
            CutExtrusion(part, sketch, _detailParameters.RodRadius);
            CutExtrusion(part, sketch, -_detailParameters.RodRadius);
        }

        /// <summary>
        /// Создать шляпку
        /// </summary>
        /// <param name="part">файл</param>
        /// <param name="_detailParameters">параметры детали</param>
        private void CreateHead(ksPart part, LinkPinParameter _detailParameters)
        {
            ksEntity plane = part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
            ksEntity sketch = part.NewEntity((int)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D document2D = sketchDefinition.BeginEdit();
            document2D.ksCircle(0, 0, _detailParameters.HeadRadius, 1);
            sketchDefinition.EndEdit();
            BossExtrusion(part, sketch, -_detailParameters.HeadLength);
        }
    }
}
