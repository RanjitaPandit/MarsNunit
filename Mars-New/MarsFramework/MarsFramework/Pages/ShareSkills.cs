using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using MarsFramework.Pages;
using MarsFramework.Global;
using MarsFramework.Config;

namespace MarsFramework.Pages
{
    internal class ShareSkills
    {
        public ShareSkills()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        string title = "API Tester";
        string description = "Testing Expert"; 
        string category = "Digital Marketing";
        string tag1 = "Testing";
        string tag2 = "API";
        string tag3 = "Java";
        string serviceoption = "Hourly";
        string strsubcategory = "Content Marketing";
        string skilltradeoption = "Skill Exchange";
        string requiredskill = "Java Developer";
        string num = "10";
        string status = "Active";
        string locationtype = "online";
        string saveorcancel = "Save";
        //string startdate = "06/02/2019";

        #region  Initialize Web Elements 
        // Share Skills button
       [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
        public IWebElement ShareSkill { get; set; }

        // Title
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement Title { get; set; }


        // Description

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement Description { get; set; }

        // Select Category

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement Category { get; set; }

        // Select Graphics & Design from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement GraphicsDesign { get; set; }


        // Finding Digital Marketing option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement DigitalMarketing { get; set; }

        // Finding  Writing & Translation option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement WritingTranslation { get; set; }

        // Finding  Video & Animation option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement VideoAnimation { get; set; }

        // Finding  Music & Audio option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement MusicAudio { get; set; }

        // Finding  Programming & Tech option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(7)")]
        public IWebElement ProgrammingTech { get; set; }

        // Finding Business option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(8)")]
        public IWebElement Business { get; set; }

        // Finding  Fun & Life Style option from Category dropdown

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(9)")]
        public IWebElement FunLifeStyle { get; set; }


        // Select SubCategory

        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement SubCategory { get; set; }

        //Select SubCategory - Logo Design from Graphics & Design Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement LogoDesign { get; set; }

        //Select SubCategory - Book & Album Cover from Graphics & Design Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement BookAlbumCover { get; set; }

        //Select SubCategory - Flyers & Brochures from Graphics & Design Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement  FlyersBrochures{ get; set; }

        //Select SubCategory - Web & Mobile Design from Graphics & Design Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement  WebMobileDesign{ get; set; }

        //Select SubCategory - Search & Display Matketing from Graphics & Design Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement SearchDisplayMarketing { get; set; }

        //Select SubCategory - Social Media Matketing from Digital Marketing Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement SocialMediaMarketing { get; set; }

        //Select SubCategory Content Marketing-  from Digital Marketing Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement ContentMarketing{ get; set; }

        //Select SubCategory Video Marketing-  from Digital Marketing Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement VideoMarking{ get; set; }

        //Select SubCategory Email Marketing-  from Digital Marketing Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement EmailMarketing{ get; set; }

        //Select SubCategory Search & Display Marketing- from Digital Marketing Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement SearchAndDisplay{ get; set; }

        //Select SubCategory Resume & Cover Letters -  from Writing & Translation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement ResumeCoverLetters{ get; set; }

        //Select SubCategory Proofreading & Editing-  from Writing & Translation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement ProofreadingEditing{ get; set; }

        //Select SubCategory Translation -  from Writing & Translation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement Translation{ get; set; }

        //Select SubCategory Creative Writing-  from Writing & Translation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement CreativeWriting{ get; set; }

        //Select SubCategory Business Copywriting -  from Writing & Translation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement BusinessCopywriting{ get; set; }

        //Select SubCategory Promotional Videos-  from Video & Animation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement PromotionalVideos { get; set; }

        //Select SubCategory Editing & Post Production -  from Video & Animation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement EditingPostProduction { get; set; }

        //Select SubCategory Lyric & Music Videos-  from Video & Animation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement LyricMusicVideos { get; set; }

        //Select SubCategory Other-  from Video & Animation Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement OtherVideoAnimation { get; set; }

        //Select SubCategory Mixing & Mastering-  from Music & Audio Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement MixingAndMastering{ get; set; }

        //Select SubCategory Voice Over-  from Music & Audio Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement VoiceOver{ get; set; }

        //Select SubCategory Songwriters & Composers-  from Music & Audio Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement SongwritersAndComposers{ get; set; }

        //Select SubCategory Other-  from Music & Audio Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement OtherMusicAudio{ get; set; }

        //Select SubCategory WordPress-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement WordPress { get; set; }

        //Select SubCategory Web & Mobile App-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement WebMobileApp { get; set; }

        //Select SubCategory Data Analysis & Reports-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement DataAnalysisReports{ get; set; }

        //Select SubCategory QA-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement QA { get; set; }

        //Select SubCategory Databases-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement Databases { get; set; }

        //Select SubCategory Other-  from Programmimng & Tech Category
        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement OtherProgrammingTech{ get; set; }

        //Select SubCategory Business Tips-  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement BusinessTips { get; set; }

        //Select SubCategory Presentations -  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement Presentations { get; set; }

        //Select SubCategory Market Advice -  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement MarketAdvice { get; set; }

        //Select SubCategory Legal Consulting-  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement LegalConsulting{ get; set; }

        //Select SubCategory Financial Consulting-  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement FinancialConsulting{ get; set; }

        //Select SubCategory Other-  from Business Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(7)")]
        public IWebElement OtherBusiness { get; set; }

        //Select SubCategory Online Lessons-  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement OnlineLessons{ get; set; }

        //Select SubCategory Relationship Advice-  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(3)")]
        public IWebElement RelationshipAdvice{ get; set; }


        //Select SubCategory Astrology -  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(4)")]
        public IWebElement Astrology { get; set; }

        //Select SubCategory Health, Nutrition & Fitness-  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(5)")]
        public IWebElement HealthNutritionFitness{ get; set; }

        //Select SubCategory Gaming -  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(6)")]
        public IWebElement Gaming { get; set; }

        //Select SubCategory Other-  from Fun & Lifestyle Category
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(7)")]
        public IWebElement OtherFunLifstyle{ get; set; }

        //Select Tag Names
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement Tag { get; set; }

        //Select Service Type -Hourly Basis
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeHourly { get; set; }

        //Select Service Type -One-off
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeOnOff { get; set; }

        //Select Location Type - Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement LocationTypeOnsite { get; set; }

        //Select Location Type - Online
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
        public IWebElement LocationTypeOnline { get; set; }

        //Avilable Days -Start Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
        public IWebElement StartDate { get; set; }

        //Avilable Days -End Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
        public IWebElement EndDate { get; set; }

        //Skill Trade - Skill Exchange
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement SkillExchange { get; set; }

        // Skill Exchange - Required Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement RequiredSkills { get; set; }

        //Skill Trade - Credit
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement Credit { get; set; }


        //Credit - Enter Amount
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
        public IWebElement CreditAmount { get; set; }

        // Status Active 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusActive { get; set; }

        // Status Hidden 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusHidden { get; set; }

        // Upload Workspace  
        [FindsBy(How = How.CssSelector, Using = "It might be a child of iframe from different src/svg/pseudo/comment & it doesn't support CSS so CSS can't be generated for this element.")]
        public IWebElement WorkspaceButton { get; set; }

        // Save Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement SaveShareSkills { get; set; }

        // Cancel Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement CancelShareSkills { get; set; }



        #endregion
        internal void AddShareSkills()
        {

            // Click on Share Skills button
            Thread.Sleep(2000);
            ShareSkill.Click();
            Thread.Sleep(2000);
            #region Enter Title
            // Enter Title
           
            Title.SendKeys(title);
            Thread.Sleep(2000);
            #endregion

            #region Enter Description
            // Enter Description
            Description.SendKeys(description);
            Thread.Sleep(2000);
            #endregion

            #region Category Drop- Down
            // select the Category from drop down list
            Category.Click();
            Thread.Sleep(2000);

            //Category selection           
            var selectElementCategory = new SelectElement(Category);
            selectElementCategory.SelectByText(category);

            //SubCategory selection  
            SubCategory.Click();
            var selectElementSubcategory = new SelectElement(SubCategory);
            selectElementSubcategory.SelectByText(strsubcategory);

            #endregion

            #region Select Tags
            // Add Tags Name -1
            Tag.SendKeys(tag1);
            // Click on Enter Key
            Tag.SendKeys(Keys.Enter);

            // Add Tags Name -2
            Tag.SendKeys(tag2);
            // Click on Enter Key
            Tag.SendKeys(Keys.Enter);

            // Add Tags Name -3
            Tag.SendKeys(tag3);
            // Click on Enter Key
            Tag.SendKeys(Keys.Enter);
            #endregion

            #region Select Service Type
            
            // Select Service Type        
            if (serviceoption == "Hourly")
            {
                //Click on Service Type Radio Button - Hourly
                ServiceTypeHourly.Click();
            }
            else if(serviceoption=="On-Off")
            {
                //Click on Service Type Radio Button - On-Off
                ServiceTypeOnOff.Click();
            }

            #endregion

            #region Select Location Type
            //Select Location Type Radio button
            if (locationtype == "Onsite")
            {
                // Select  Onsite
                LocationTypeOnsite.Click();
            }
            else if (locationtype == "online")
            {
                // Select Online
                LocationTypeOnline.Click();
            }
            
            #endregion

            #region Select Available Days
                // Yet to Implement PickDate from Calendar
                //Available Dates - Start Date
                 StartDate.Click();
                
                //Available Dates - End Date
                EndDate.Click();
               
            #endregion

            #region Select Skill Trade
         
            // Select Skill Trade       
            if (skilltradeoption == "skillexchange")
            {
                //Click on Service Type Radio Button - Skill Exchange
                SkillExchange.Click();
                // Eneter Required Skill
                RequiredSkills.SendKeys(requiredskill);
                //Select and Enter the Required Skill
                RequiredSkills.SendKeys(Keys.Enter);
            }
            else if (skilltradeoption == "Credit")
            {
                //Click on Service Type Radio Button - Credit
                Credit.Click();                
                //Enter the amount
                Credit.SendKeys(num);
                RequiredSkills.SendKeys(Keys.Enter);
            }




            #endregion

            #region Active or Hidden Status
            if (status == "Active")
            {
                //Select Active Status
                StatusActive.Click();
            }
            else if (status == "Hidden")
            {
                // Select Hidden Status
                StatusHidden.Click();
            }
            #endregion

            #region Workspace Sample
            /* Yet to Test all Types of files
            // Add File
            WorkspaceButton.Click();
            WorkspaceButton.SendKeys(@"C:\Users\Ranjita\Desktop\MVP\Test Files\Assignment1");
            Thread.Sleep(3000); */
            #endregion

            #region  Save Skills

            if (saveorcancel == "Save")
            {
                // Save  Sahre Skill Page
                SaveShareSkills.Click();
            }
            
            #endregion
           

            #region Cancel Skills
            else if (saveorcancel == "Cancel")
            {
                // Cancel a Share Skill Page
                CancelShareSkills.Click();
            }
            #endregion


            Thread.Sleep(1500);         


        }
    
    }
}
