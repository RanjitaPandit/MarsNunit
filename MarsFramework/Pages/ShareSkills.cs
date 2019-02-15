using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MarsFramework.Pages
{
   public class ShareSkills
    {
        public ShareSkills()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        # region Initialize Web Elements 
        // Finding  Dashboard button
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[1]/div/a[1]")]
        public IWebElement Dashboard { get; set; }

        // Finding Skills button 
        [FindsBy(How = How.ClassName, Using = "item active")]
        public IWebElement Skills { get; set; }


        //Finding Share Skills button
        [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
        public IWebElement ShareSkill { get; set; }
        

       
        // Finding Title field
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement Title { get; set; }
        


        // Finding Description field

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement Description { get; set; }

        // Finding Category Dropdown

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement Category { get; set; }


        // Finding Graphics & Design option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement GraphicsDesign { get; set; }

        // Finding Digital Marketing option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement  DigitalMarketing{ get; set; }

         // Finding  Writing & Translation option from Category dropdown

         [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
         public IWebElement  WritingTranslation{ get; set; }
        
        // Finding  Video & Animation option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement VideoAnimation { get; set; }

        // Finding  Music & Audio option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement  MusicAudio{ get; set; }

        // Finding  Programming & Tech option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(7)")]
        public IWebElement  ProgrammingTech{ get; set; }

        // Finding Business option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(8)")]
        public IWebElement  Business{ get; set; }

        // Finding  Fun & Life Style option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(9)")]
        public IWebElement  FunLifeStyle{ get; set; }



        //Finding & Selecting SubCategory 

        // Finding Logo Design from SubCategory- Graphics & Design dropdown
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement LogoDesign { get; set; }

        
        //Finding Tag Names
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement Tag { get; set; }

        //FInding Select Service Type -Hourly Basis
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeHourly { get; set; }

        //finding Select Service Type -One-off
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeOnOff { get; set; }

        //Finding Select Location Type -as Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement LocationTypeOnsite { get; set; }

        //Finding Select Location Type - as Online
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
        public IWebElement LocationTypeOnline { get; set; }

        //Finding Avilable Days -Start Date field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
        public IWebElement StartDate { get; set; }

        //Finding Avilable Days -End Date field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
        public IWebElement EndDate { get; set; }

        //Finding Skill Trade - Skill Exchange field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement SkillExchange { get; set; }

        // Finding Skill Exchange - Required Skills field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement RequiredSkills { get; set; }

        //Finding Skill Trade - Credit field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement Credit { get; set; }


        //Finding Credit - Enter Amount field
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
        public IWebElement CreditAmount { get; set; }

        // Finding Status - Active Type
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusActive { get; set; }

        // Finding Status - Hidden Type
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusHidden { get; set; }

        // Finding Save Share Skills button
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement SaveShareSkills { get; set; }

        // Finding Cancel Share Skills button
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement CancelShareSkills { get; set; }
        #endregion
        public void ShareSkillsSteps()
        {
            IWebElement element = GlobalDefinitions.driver.FindElement(By.CssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) > select.ui.fluid.dropdown"));
            IList<IWebElement> AllDropDownList = element.FindElements(By.CssSelector(""));
            int DpListCount = AllDropDownList.Count;
            for (int i = 0; i < DpListCount; i++)
            {
                if (AllDropDownList[i].Text == "categoryId")
                {
                    AllDropDownList[i].Click();
                }
            }
        }

            }


}
