<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_e376c751e330419d3f9a1a4b0a70adfbd1d2211ad6355062ee234a1596327f48 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_dd1884ab3fba31d7bf9e0dbf814156a36a0dac53c4cb8da56e0da3c2f277c297 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dd1884ab3fba31d7bf9e0dbf814156a36a0dac53c4cb8da56e0da3c2f277c297->enter($__internal_dd1884ab3fba31d7bf9e0dbf814156a36a0dac53c4cb8da56e0da3c2f277c297_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $__internal_98cd0616a71413fd66ca0c5bfd7419a9b92bb21a1643377b30cb7df53658dbfb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_98cd0616a71413fd66ca0c5bfd7419a9b92bb21a1643377b30cb7df53658dbfb->enter($__internal_98cd0616a71413fd66ca0c5bfd7419a9b92bb21a1643377b30cb7df53658dbfb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_dd1884ab3fba31d7bf9e0dbf814156a36a0dac53c4cb8da56e0da3c2f277c297->leave($__internal_dd1884ab3fba31d7bf9e0dbf814156a36a0dac53c4cb8da56e0da3c2f277c297_prof);

        
        $__internal_98cd0616a71413fd66ca0c5bfd7419a9b92bb21a1643377b30cb7df53658dbfb->leave($__internal_98cd0616a71413fd66ca0c5bfd7419a9b92bb21a1643377b30cb7df53658dbfb_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_1511e8a6cd640a02fc11f8161e00bcd1312b2f95ff069f9d80ba64b5e92e272d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1511e8a6cd640a02fc11f8161e00bcd1312b2f95ff069f9d80ba64b5e92e272d->enter($__internal_1511e8a6cd640a02fc11f8161e00bcd1312b2f95ff069f9d80ba64b5e92e272d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_de9d57497e557ca70e11bf198f0586f8aab30498da7223e30097c730263c1d9b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_de9d57497e557ca70e11bf198f0586f8aab30498da7223e30097c730263c1d9b->enter($__internal_de9d57497e557ca70e11bf198f0586f8aab30498da7223e30097c730263c1d9b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
";
        
        $__internal_de9d57497e557ca70e11bf198f0586f8aab30498da7223e30097c730263c1d9b->leave($__internal_de9d57497e557ca70e11bf198f0586f8aab30498da7223e30097c730263c1d9b_prof);

        
        $__internal_1511e8a6cd640a02fc11f8161e00bcd1312b2f95ff069f9d80ba64b5e92e272d->leave($__internal_1511e8a6cd640a02fc11f8161e00bcd1312b2f95ff069f9d80ba64b5e92e272d_prof);

    }

    // line 136
    public function block_title($context, array $blocks = array())
    {
        $__internal_505285ec517cbbcc4490815e29fd3912a092b5a6708bbbcd23915897e7aefad9 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_505285ec517cbbcc4490815e29fd3912a092b5a6708bbbcd23915897e7aefad9->enter($__internal_505285ec517cbbcc4490815e29fd3912a092b5a6708bbbcd23915897e7aefad9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_cdad94d62e0f9d0d2c43d454ec311b4562a64f0e63b9ccbe232d69af059f03c6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cdad94d62e0f9d0d2c43d454ec311b4562a64f0e63b9ccbe232d69af059f03c6->enter($__internal_cdad94d62e0f9d0d2c43d454ec311b4562a64f0e63b9ccbe232d69af059f03c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 137
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute(($context["exception"] ?? $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, ($context["status_code"] ?? $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, ($context["status_text"] ?? $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_cdad94d62e0f9d0d2c43d454ec311b4562a64f0e63b9ccbe232d69af059f03c6->leave($__internal_cdad94d62e0f9d0d2c43d454ec311b4562a64f0e63b9ccbe232d69af059f03c6_prof);

        
        $__internal_505285ec517cbbcc4490815e29fd3912a092b5a6708bbbcd23915897e7aefad9->leave($__internal_505285ec517cbbcc4490815e29fd3912a092b5a6708bbbcd23915897e7aefad9_prof);

    }

    // line 140
    public function block_body($context, array $blocks = array())
    {
        $__internal_b591f7dba0c897d58ce74a44b228782c7d08358b619a46715d53c20ed51f1a56 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b591f7dba0c897d58ce74a44b228782c7d08358b619a46715d53c20ed51f1a56->enter($__internal_b591f7dba0c897d58ce74a44b228782c7d08358b619a46715d53c20ed51f1a56_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_e36567ec61bca8ee1efcd98d333032be85e2b44db7615c9f2fcf90e6eeedf5cf = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e36567ec61bca8ee1efcd98d333032be85e2b44db7615c9f2fcf90e6eeedf5cf->enter($__internal_e36567ec61bca8ee1efcd98d333032be85e2b44db7615c9f2fcf90e6eeedf5cf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 141
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 141)->display($context);
        
        $__internal_e36567ec61bca8ee1efcd98d333032be85e2b44db7615c9f2fcf90e6eeedf5cf->leave($__internal_e36567ec61bca8ee1efcd98d333032be85e2b44db7615c9f2fcf90e6eeedf5cf_prof);

        
        $__internal_b591f7dba0c897d58ce74a44b228782c7d08358b619a46715d53c20ed51f1a56->leave($__internal_b591f7dba0c897d58ce74a44b228782c7d08358b619a46715d53c20ed51f1a56_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  226 => 141,  217 => 140,  200 => 137,  191 => 136,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
", "@Twig/Exception/exception_full.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\Exception\\exception_full.html.twig");
    }
}
