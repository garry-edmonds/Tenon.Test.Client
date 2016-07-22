using System;
using System.Text.RegularExpressions;
using Tenon.Test.Client.Exceptions;
using static Tenon.Test.Client.Settings.Parameters;

namespace Tenon.Test.Client.Settings
{
    public abstract class OptionalParameters
    {
        internal abstract string _postData { get; set; }

        /// <summary>
        /// Allows you to change the certainty value of the test run.
        /// </summary>
        /// <param name="curtainty">Enums of available values.</param>
        public void SetCertainty(Certainty curtainty)
        {
            _postData += ("&certainty=" + (int)curtainty);
        }

        /// <summary>
        /// Text value that you can supply to identify the tested document.
        /// </summary>
        /// <param name="projectId">The project id to use for the test run.</param>
        public void SetProjectID(string projectId)
        {
            if (projectId.Length > 255)
            {
                throw new InvalidStringLengthException("Project ID can only be upto 255 characters long");
            }
            _postData += ("&projectID=" + projectId);
        }

        /// <summary>
        /// Text value to identify the page being tested.
        /// </summary>
        /// <param name="docID">Text value of the document.</param>
        public void SetDocID(string docID)
        {
            if (docID.Length < 16 || docID.Length > 255)
            {
                throw new InvalidStringLengthException("Doc ID can only be between 16 amd 255 characters long");
            }
            
            var regex = @"^[a-zA-Z0-9_\-]+$";
            if (!Regex.IsMatch(docID, regex))
            {
                throw new InvalidValueException("Doc ID can only contain a-z A-Z 0-9 dash(-) and underscore(_) values.");
            }

            _postData += ("&docID=" + docID);
        }

        /// <summary>
        /// Allows you to change the priority value of the test run.
        /// </summary>
        /// <param name="priority">Enum of available values that can be set.</param>
        public void SetPriority(Priority priority)
        {
            _postData += ("&priority=" + (int)priority);
        }

        /// <summary>
        /// Allows you to change the value of 'WCAG' for the test run.
        /// </summary>
        /// <param name="level">Enum of available values that can be set.</param>
        public void SetLevel(Level level)
        {
            _postData += ("&level=" + level);
        }

        /// <summary>
        /// Numeric value of the amount of time to wait before the test run starts.
        /// </summary>
        /// <param name="milliseconds">Time in milliseconds to wait.</param>
        public void SetWaitFor(int milliseconds)
        {
            _postData += ("&waitFor=" + milliseconds);
        }

        /// <summary>
        /// Only used for page source testing to state the source code is a fragment of a page.
        /// </summary>
        /// <param name="enable">True or False value.</param>
        public void SetFragment(bool enable)
        {
            _postData += ("&fragment=" + Convert.ToInt32(enable));
        }

        /// <summary>
        /// The level of importance that the page is to the site.
        /// </summary>
        /// <param name="importance">Enum of avaiable values for importance.</param>
        public void SetImportance(Importance importance)
        {
            _postData += ("&importance=" + (int)importance);
        }

        /// <summary>
        /// Paramenter to show if you require a link against each issue of the best practice.
        /// </summary>
        /// <param name="enable">True of False value.</param>
        public void SetRef(bool enable)
        {
            _postData += ("&ref=" + Convert.ToInt32(enable));
        }

        /// <summary>
        /// If set then the test results will be stored for later viewing.
        /// </summary>
        /// <param name="enable"></param>
        public void SetStore(bool enable)
        {
            _postData += ("&store=" + Convert.ToInt32(enable));
        }

        /// <summary>
        /// A string value which will be sent as the User-Agent value.
        /// </summary>
        /// <param name="uaString">String value of User-Agent.</param>
        public void SetUaString(string uaString)
        {
            if (uaString.Length > 255)
            {
                throw new InvalidStringLengthException("uaString can only be upto 255 characters long");
            }
            _postData += ("&projectID=" + uaString);
        }

        /// <summary>
        /// Height in pixels of the headless browser.
        /// </summary>
        /// <param name="height">Value between 0 and 9999.</param>
        public void SetViewPortHeight(int height)
        {
            if (height < 0 || height > 9999)
            {
                throw new InvalidNumberValueException("ViewPortHeight can only be between 0 and 9999");
            }
            _postData += ("&viewPortHeight=" + height);
        }

        /// <summary>
        /// Width in pixels of the headless browser.
        /// </summary>
        /// <param name="width">Value between 0 and 9999.</param>
        public void SetViewPortWidth(int width)
        {
            if (width < 0 || width > 9999)
            {
                throw new InvalidNumberValueException("ViewPortWidth can only be between 0 and 9999");
            }
            _postData += ("&viewPortWidth=" + width);
        }

    }
}
