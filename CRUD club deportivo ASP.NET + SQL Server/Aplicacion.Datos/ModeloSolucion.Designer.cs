﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("solucion_fetachModel", "fk_asociacion_arquero", "asociacion", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Aplicacion.Datos.asociacion), "arquero", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Aplicacion.Datos.arquero), true)]

#endregion

namespace Aplicacion.Datos
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class solucion_fetachEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto solucion_fetachEntities usando la cadena de conexión encontrada en la sección 'solucion_fetachEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public solucion_fetachEntities() : base("name=solucion_fetachEntities", "solucion_fetachEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto solucion_fetachEntities.
        /// </summary>
        public solucion_fetachEntities(string connectionString) : base(connectionString, "solucion_fetachEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto solucion_fetachEntities.
        /// </summary>
        public solucion_fetachEntities(EntityConnection connection) : base(connection, "solucion_fetachEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<arquero> arqueroes
        {
            get
            {
                if ((_arqueroes == null))
                {
                    _arqueroes = base.CreateObjectSet<arquero>("arqueroes");
                }
                return _arqueroes;
            }
        }
        private ObjectSet<arquero> _arqueroes;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<asociacion> asociacions
        {
            get
            {
                if ((_asociacions == null))
                {
                    _asociacions = base.CreateObjectSet<asociacion>("asociacions");
                }
                return _asociacions;
            }
        }
        private ObjectSet<asociacion> _asociacions;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<usuario> usuarios
        {
            get
            {
                if ((_usuarios == null))
                {
                    _usuarios = base.CreateObjectSet<usuario>("usuarios");
                }
                return _usuarios;
            }
        }
        private ObjectSet<usuario> _usuarios;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet arqueroes. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToarqueroes(arquero arquero)
        {
            base.AddObject("arqueroes", arquero);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet asociacions. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToasociacions(asociacion asociacion)
        {
            base.AddObject("asociacions", asociacion);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet usuarios. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTousuarios(usuario usuario)
        {
            base.AddObject("usuarios", usuario);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="solucion_fetachModel", Name="arquero")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class arquero : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto arquero.
        /// </summary>
        /// <param name="rut">Valor inicial de la propiedad rut.</param>
        /// <param name="nombre_completo">Valor inicial de la propiedad nombre_completo.</param>
        /// <param name="direccion">Valor inicial de la propiedad direccion.</param>
        /// <param name="asociacion">Valor inicial de la propiedad asociacion.</param>
        /// <param name="fecha_nacimiento">Valor inicial de la propiedad fecha_nacimiento.</param>
        /// <param name="al_dia">Valor inicial de la propiedad al_dia.</param>
        public static arquero Createarquero(global::System.String rut, global::System.String nombre_completo, global::System.String direccion, global::System.Int32 asociacion, global::System.DateTime fecha_nacimiento, global::System.Boolean al_dia)
        {
            arquero arquero = new arquero();
            arquero.rut = rut;
            arquero.nombre_completo = nombre_completo;
            arquero.direccion = direccion;
            arquero.asociacion = asociacion;
            arquero.fecha_nacimiento = fecha_nacimiento;
            arquero.al_dia = al_dia;
            return arquero;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String rut
        {
            get
            {
                return _rut;
            }
            set
            {
                if (_rut != value)
                {
                    OnrutChanging(value);
                    ReportPropertyChanging("rut");
                    _rut = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("rut");
                    OnrutChanged();
                }
            }
        }
        private global::System.String _rut;
        partial void OnrutChanging(global::System.String value);
        partial void OnrutChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre_completo
        {
            get
            {
                return _nombre_completo;
            }
            set
            {
                Onnombre_completoChanging(value);
                ReportPropertyChanging("nombre_completo");
                _nombre_completo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre_completo");
                Onnombre_completoChanged();
            }
        }
        private global::System.String _nombre_completo;
        partial void Onnombre_completoChanging(global::System.String value);
        partial void Onnombre_completoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                OndireccionChanging(value);
                ReportPropertyChanging("direccion");
                _direccion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("direccion");
                OndireccionChanged();
            }
        }
        private global::System.String _direccion;
        partial void OndireccionChanging(global::System.String value);
        partial void OndireccionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 asociacion
        {
            get
            {
                return _asociacion;
            }
            set
            {
                OnasociacionChanging(value);
                ReportPropertyChanging("asociacion");
                _asociacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("asociacion");
                OnasociacionChanged();
            }
        }
        private global::System.Int32 _asociacion;
        partial void OnasociacionChanging(global::System.Int32 value);
        partial void OnasociacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime fecha_nacimiento
        {
            get
            {
                return _fecha_nacimiento;
            }
            set
            {
                Onfecha_nacimientoChanging(value);
                ReportPropertyChanging("fecha_nacimiento");
                _fecha_nacimiento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fecha_nacimiento");
                Onfecha_nacimientoChanged();
            }
        }
        private global::System.DateTime _fecha_nacimiento;
        partial void Onfecha_nacimientoChanging(global::System.DateTime value);
        partial void Onfecha_nacimientoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean al_dia
        {
            get
            {
                return _al_dia;
            }
            set
            {
                Onal_diaChanging(value);
                ReportPropertyChanging("al_dia");
                _al_dia = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("al_dia");
                Onal_diaChanged();
            }
        }
        private global::System.Boolean _al_dia;
        partial void Onal_diaChanging(global::System.Boolean value);
        partial void Onal_diaChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("solucion_fetachModel", "fk_asociacion_arquero", "asociacion")]
        public asociacion asociacion1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<asociacion>("solucion_fetachModel.fk_asociacion_arquero", "asociacion").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<asociacion>("solucion_fetachModel.fk_asociacion_arquero", "asociacion").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<asociacion> asociacion1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<asociacion>("solucion_fetachModel.fk_asociacion_arquero", "asociacion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<asociacion>("solucion_fetachModel.fk_asociacion_arquero", "asociacion", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="solucion_fetachModel", Name="asociacion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class asociacion : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto asociacion.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre_asociacion">Valor inicial de la propiedad nombre_asociacion.</param>
        /// <param name="direccion">Valor inicial de la propiedad direccion.</param>
        public static asociacion Createasociacion(global::System.Int32 id, global::System.String nombre_asociacion, global::System.String direccion)
        {
            asociacion asociacion = new asociacion();
            asociacion.id = id;
            asociacion.nombre_asociacion = nombre_asociacion;
            asociacion.direccion = direccion;
            return asociacion;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre_asociacion
        {
            get
            {
                return _nombre_asociacion;
            }
            set
            {
                Onnombre_asociacionChanging(value);
                ReportPropertyChanging("nombre_asociacion");
                _nombre_asociacion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre_asociacion");
                Onnombre_asociacionChanged();
            }
        }
        private global::System.String _nombre_asociacion;
        partial void Onnombre_asociacionChanging(global::System.String value);
        partial void Onnombre_asociacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                OndireccionChanging(value);
                ReportPropertyChanging("direccion");
                _direccion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("direccion");
                OndireccionChanged();
            }
        }
        private global::System.String _direccion;
        partial void OndireccionChanging(global::System.String value);
        partial void OndireccionChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("solucion_fetachModel", "fk_asociacion_arquero", "arquero")]
        public EntityCollection<arquero> arqueroes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<arquero>("solucion_fetachModel.fk_asociacion_arquero", "arquero");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<arquero>("solucion_fetachModel.fk_asociacion_arquero", "arquero", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="solucion_fetachModel", Name="usuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class usuario : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto usuario.
        /// </summary>
        /// <param name="nombre_usuario">Valor inicial de la propiedad nombre_usuario.</param>
        /// <param name="nombre_completo">Valor inicial de la propiedad nombre_completo.</param>
        /// <param name="contrasenna">Valor inicial de la propiedad contrasenna.</param>
        public static usuario Createusuario(global::System.String nombre_usuario, global::System.String nombre_completo, global::System.String contrasenna)
        {
            usuario usuario = new usuario();
            usuario.nombre_usuario = nombre_usuario;
            usuario.nombre_completo = nombre_completo;
            usuario.contrasenna = contrasenna;
            return usuario;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre_usuario
        {
            get
            {
                return _nombre_usuario;
            }
            set
            {
                if (_nombre_usuario != value)
                {
                    Onnombre_usuarioChanging(value);
                    ReportPropertyChanging("nombre_usuario");
                    _nombre_usuario = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("nombre_usuario");
                    Onnombre_usuarioChanged();
                }
            }
        }
        private global::System.String _nombre_usuario;
        partial void Onnombre_usuarioChanging(global::System.String value);
        partial void Onnombre_usuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre_completo
        {
            get
            {
                return _nombre_completo;
            }
            set
            {
                Onnombre_completoChanging(value);
                ReportPropertyChanging("nombre_completo");
                _nombre_completo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre_completo");
                Onnombre_completoChanged();
            }
        }
        private global::System.String _nombre_completo;
        partial void Onnombre_completoChanging(global::System.String value);
        partial void Onnombre_completoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String contrasenna
        {
            get
            {
                return _contrasenna;
            }
            set
            {
                OncontrasennaChanging(value);
                ReportPropertyChanging("contrasenna");
                _contrasenna = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("contrasenna");
                OncontrasennaChanged();
            }
        }
        private global::System.String _contrasenna;
        partial void OncontrasennaChanging(global::System.String value);
        partial void OncontrasennaChanged();

        #endregion

    
    }

    #endregion

    
}