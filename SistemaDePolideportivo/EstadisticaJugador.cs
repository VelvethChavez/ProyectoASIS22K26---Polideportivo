using System;

namespace SistemaDePolideportivo.Modelos
{
    public class EstadisticaJugador
    {
        //==============================
        // TABLA ESTADISTICA_JUGADOR
        //==============================

        public int IdEstadistica { get; set; }

        public int IdJugador { get; set; }

        public int IdPartido { get; set; }

        public string Observaciones { get; set; } = string.Empty;

        //==============================
        // PARA SABER EN QUÉ TABLA GUARDAR
        //==============================

        public string Deporte { get; set; } = string.Empty;

        //==============================
        // FUTBOL
        //==============================

        public int Goles { get; set; }

        public int AsistenciasFutbol { get; set; }

        public int TarjetasAmarillas { get; set; }

        public int TarjetasRojas { get; set; }

        //==============================
        // BALONCESTO
        //==============================

        public int PuntosBaloncesto { get; set; }

        public int AsistenciasBaloncesto { get; set; }

        public int Canastas { get; set; }

        //==============================
        // VOLEIBOL
        //==============================

        public int PuntosVoleibol { get; set; }

        public int SetsGanadosVoleibol { get; set; }

        //==============================
        // TENIS
        //==============================

        public int PuntosTenis { get; set; }

        public int SetsGanadosTenis { get; set; }

        public string NombreJugador { get; set; } = string.Empty;

        public string NombrePartido { get; set; } = string.Empty;
    }

}

