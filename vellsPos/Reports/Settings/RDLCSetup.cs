using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Reports.Settings
{
    internal class RDLCSetup
    {
        public static PageSettings getPageSettings()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            ps.Margins = new Margins(44, 0, 44, 44);
            //ps.Margins = new Margins(40, 40, 40, 40);
            return ps;
        }

        public static PageSettings getPageSettingsWithZeroMargin()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            ps.Margins = new Margins(0, 0, 0, 0);
            return ps;
        }

        public static PageSettings getLandscapePageSettingsWithZeroMargin()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            ps.Landscape = true;
            ps.Margins = new Margins(0, 0, 0, 0);
            return ps;
        }

        public static PageSettings getA5PageSettingsWithZeroMargin()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A5;
            ps.Margins = new Margins(0, 0, 0, 0);
            return ps;
        }

        public static PageSettings getBillPageSettings()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            ps.Margins = new Margins(40, 40, 0, 55);
            return ps;
        }

        public static PageSettings getLandscapePageSettings()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            ps.Landscape = true;
            ps.Margins = new Margins(44, 0, 44, 44);
            //ps.Margins = new Margins(0, 0, 55, 55);
            return ps;
        }

        public static PageSettings getA3LandscapePageSettingsWithZeroMargin()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A3;
            ps.Landscape = true;
            ps.Margins = new Margins(0, 0, 0, 0);
            return ps;
        }

        public static PageSettings getA3LandscapePageSettings()
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize.RawKind = (int)PaperKind.A3;
            ps.Landscape = true;
            ps.Margins = new Margins(44, 0, 44, 44);
            //ps.Margins = new Margins(55, 0, 55, 55);
            return ps;
        }
    }
}
