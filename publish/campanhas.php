<?php include("pageHeader.php"); ?>
<?php
$pageName = "Campanhas";
?>
<?php include("breadcrumb.php"); ?>


            <div class="row">
                <div class="col-12 mb-5">
                    <h1><?php echo $pageName ?></h1>  
                    <div>                       
                        <!--Indicadores-->
                        <!--Info-->
                        <a class="mr-lg-2" id="info" href="#">
                            <i class="fa fa-fw fa-info-circle text-dark"></i>
                            <span class="d-lg-none">Total</span>
                            <span class="badge badge-pill badge-dark">1235</span>
                        </a>
                        <a class="mr-lg-2" id="ok" href="#">
                            <i class="fa fa-fw fa-check-circle text-success"></i>
                            <span class="d-lg-none">OK</span>
                            <span class="badge badge-pill badge-success">1235</span>
                        </a>
                        <a class="mr-lg-2" id="Error" href="#">
                            <i class="fa fa-fw fa-exclamation-circle text-danger"></i>
                            <span class="d-lg-none">Com problemas</span>
                            <span class="badge badge-pill badge-danger">1235</span>
                        </a>     
                        <a class="mr-lg-5" id="New" href="#">
                            <i class="fa fa-fw fa-plus-circle text-primary"></i>
                            <span class="text-dark">Novo</span>
                        </a>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <!--Table-->
                    <div class="col-10 mb-5">
                        <table data-toggle="table" data-search="true" data-show-columns="true">
                            <thead>
                                <tr class="tr-class-1">
                                    <th data-field="nome" data-valign="middle">Nome</th>
                                    <th data-field="cliente">Cliente</th>
                                    <th data-field="dataFim">Termino</th>                                    
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="tr-id-1" class="tr-class-1" data-title="Campanha table" data-object='{"key": "value"}'>
                                    <td id="td-id-1" class="td-class-1">Campanha 01</td>
                                    <td>Itaú</td>
                                    <td></td>                                    
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-2" class="tr-class-2">
                                    <td id="td-id-2" class="td-class-2">Campanha 02</td>
                                    <td>Sulamerica</td>
                                    <td></td>                                    
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-3" class="tr-class-3">
                                    <td id="td-id-3" class="td-class-3">Campanha 03</td>
                                    <td>Itaú</td>
                                    <td></td>                                    
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-4" class="tr-class-4">
                                    <td id="td-id-4" class="td-class-4">Campanha 04</td>
                                    <td>Vivo</td>
                                    <td></td>                                    
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-5" class="tr-class-5">
                                    <td id="td-id-5" class="td-class-5">Campanha 05</td>
                                    <td>BB</td>
                                    <td></td>                                    
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                    <!--Form-->
                    <div class="col-10 mb-5">
                        <div class="card text-white bg-dark o-hidden h-100">
                            <div class="card-header">
                                <div class="mr-5">
                                    <h4>
                                        <i class="fa fa-fw fa-money"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label for="nomeCampanha">Nome</label>
                                            <input type="text" class="form-control" name="nomeCampanha" id="nomeCampanha" placeholder="Digite o nome da Campanha" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label for="cliente">Cliente</label>
                                            <input type="text" class="form-control" name="cliente" id="cliente" placeholder="Digite o nome do Cliente" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="dataInicio">Data Início</label>
                                            <input type="datetime" class="form-control" name="dataInicio" id="dataInicio" placeholder="Digite data de Início" />
                                        </div>
                                        <div class="col-md-6">
                                            <label for="dataFim">Data Fim</label>
                                            <input type="datetime" class="form-control" name="dataFim" id="dataFim" placeholder="Digite data de Termino" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="fatorConversao">Fator Conversão</label>
                                            <input type="number" class="form-control" name="fatorConversao" id="fatorConversao" placeholder="Digite o Fator de Conversão" />
                                        </div>
                                        <div class="col-md-6">
                                            <label for="taxa">Taxa</label>
                                            <input type="number" class="form-control" name="taxa" id="taxa" placeholder="Digite a Taxa" />
                                        </div>
                                    </div>                                    
                                </div>
                                <div class="card-footer bg-dark pull-right">
                                    <button class="btn btn-success" type="submit">Salvar</button>
                                    <button class="btn btn-danger" type="reset">Cancelar</button>
                                </div>
                            </form>

                        </div>
                    </div>
                </div>    

            </div>
 
<?php include("pageFooter.php"); ?>
